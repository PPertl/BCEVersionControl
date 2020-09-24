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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {

            InitializeComponent();
            lblFullName.Text = Resource.FullName;

            btnAdd.Text = Resource.Add;
            btnFajlbaIr.Text = Resource.WriteToFile;

            // listbox1
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text

            };
            users.Add(u);
        }

        private void btnFajlbaIr_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    foreach (User item in users)
                    {
                        sw.WriteLine("teljes név: " + item.FullName);
                        sw.WriteLine("ID: " + item.ID);
                        sw.WriteLine();
                    }

                }
            }

        }
    }
}
