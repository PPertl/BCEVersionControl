using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szimulacio.Entities;

namespace Szimulacio
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

        Random rng = new Random(1234);

        List<string> Men = new List<string>();
        List<string> Women = new List<string>();
        List<string> Years = new List<string>();

        public int endDate = 2025;

        public Form1()
        {
            InitializeComponent();

            
            BirthProbabilities = GetBirthProbabilities(@"C:\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Temp\halál.csv");

            




        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;


        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> BirthProbabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    BirthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }

            return BirthProbabilities;

        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    DeathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2])                        
                    });
                }
            }

            return DeathProbabilities;

        }

        public void simulation()
        {
            richTextBox1.Text = "";
            Men.Clear();
            Women.Clear();
            Years.Clear();
            Population = GetPopulation(textBox1.Text);
            // Végigmegyünk a vizsgált éveken
            for (int year = 2005; year <= endDate; year++)
            {
                // Végigmegyünk az összes személyen
                for (int i = 0; i < Population.Count; i++)
                {
                    Person person = Population[i];
                    SimStep(year, person);

                }
                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                Men.Add(nbrOfMales.ToString());
                Women.Add(nbrOfFemales.ToString());
                Years.Add(year.ToString());

                //Console.WriteLine(
                //    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
            }
            DisplayResults();
        }
        public void SimStep(int year, Person person)
        {
            //Ha halott akkor kihagyjuk, ugrunk a ciklus következő lépésére
            if (!person.IsAlive) return;
            // Letároljuk az életkort, hogy ne kelljen mindenhol újraszámolni
            byte age = (byte)(year - person.BirthYear);
            // Halál kezelése
            // Halálozási valószínűség kikeresése
            double pDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();

            // Meghal a személy?
            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;
            //Születés kezelése - csak az élő nők szülnek
            if ( person.IsAlive && person.Gender == Gender.Female)
            {
                //Szülési valószínűség kikeresése
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();
                //Születik gyermek?
                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person();
                    újszülött.BirthYear = year;
                    újszülött.NbrOfChildren = 0;
                    újszülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újszülött);
                }

            }


        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            simulation();

        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Megnyitás";
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {


                textBox1.Text = openFileDialog.FileName;
            }



        }

       
        public void DisplayResults()
        {
            for (int i = 0; i < Years.Count; i++)
            {
                richTextBox1.Text += "Szimulációs év: " + Years[i]
                    + "\n \t" + "Fiúk: " + Men[i]
                    + "\n \t" + "Lányok: " + Women[i] + "\n \n";
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            endDate = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
        }
    }
}
