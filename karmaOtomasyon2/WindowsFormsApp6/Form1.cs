using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.BackColor = Color.Yellow;
            }
            else if (radioButton2.Checked)
            {
                groupBox1.BackColor= Color.Aqua;
            }
            else if (radioButton3.Checked)
            {
                groupBox1.BackColor=Color.Green;
            }
            else
            {
                groupBox1.BackColor = Color.Gold;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string secilen = Convert.ToString(comboBox1.SelectedIndex); 
            if (secilen== "Yaz")
            {
                listBox1.Items.Add("Haziran");
                listBox1.Items.Add("Temmuz");
                listBox1.Items.Add("Ağusros");

            }
            else if (secilen == "Sonbahar")
            {
                listBox1.Items.Add("Eylül");
                listBox1.Items.Add("Ekim");
                listBox1.Items.Add("Kasım");

            }
            else if (secilen == "Kış")
            {
                listBox1.Items.Add("Aralık");
                listBox1.Items.Add("Ocak");
                listBox1.Items.Add("Şubat");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rSayi = rnd.Next(1, 100);
            listBox2.Items.Add(rSayi);
        }
    }
}
