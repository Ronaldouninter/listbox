using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBoxAnimales.Items.Add("Perro");
            ListBoxAnimales.Items.Add("Gato");
            ListBoxAnimales.Items.Add("Conejo");
            ListBoxAnimales.Items.Add("Pez");
        }

        private void ListBoxAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string animal = ListBoxAnimales.SelectedItem.ToString();

            switch (animal) 
            {
                case "Perro":
                    PictureBoxAnimales.Image= Image.FromFile("C:\\Users\\minilab-ing10\\source\\repos\\listbox\\listbox\\perro.jpg");
                    break;
                default:
                    break;
            }
        }
    }
}
