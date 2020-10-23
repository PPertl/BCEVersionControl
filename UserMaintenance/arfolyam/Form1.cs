using arfolyam.entities;
using arfolyam.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace arfolyam
{

    public partial class Form1 : Form
    {
        public string result = "";
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            GetCurrencies();
            RefreshData();




        }



        public string Mnbfüggvény()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                //currencyNames = comboBox1.SelectedItem.ToString(),
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.ToString(),
                endDate = dateTimePicker2.Value.ToString()

            };
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;


            string lekerdezettXml = result.ToString();
            return lekerdezettXml;
        }
        public void XMLFeldolgozo()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                RateData RD = new RateData();
                Rates.Add(RD); //referencia típusú változó utólag is feltölthető!

                RD.Date = DateTime.Parse(element.GetAttribute("date"));

                // Valuta
                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                RD.Currency = childElement.GetAttribute("curr");

                // Érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    RD.Value = value / unit;


            }
        }

        public void AdatokMegjelenitese()
        {
            dataGridView1.DataSource = Rates;
            chartRateData.DataSource = Rates;
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

            comboBox1.DataSource = Currencies;
        }

        public void RefreshData()
        {
            Rates.Clear();
            result = Mnbfüggvény();
            XMLFeldolgozo();
            AdatokMegjelenitese();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var Getcurrencies1 = new GetCurrenciesRequestBody() { };

            var response = mnbService.GetCurrencies(Getcurrencies1);
            var result = response.GetCurrenciesResult;
            var xml = new XmlDocument();
            xml.LoadXml(result);


            string hentespult=xml.InnerText.ToString();

            for (int i = 0; i <= hentespult.Length;)
            {
                if (i+3<hentespult.Length)
                {
                    string darab = hentespult.Substring(i, 3);
                    Currencies.Add(darab);

                }

                i += 3;
            }


        }
    }
}

