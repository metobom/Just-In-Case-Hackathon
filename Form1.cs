using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HACKATHON_2020_YTU
{
    public partial class MainMenu : Form
    {
        //variables
        string combo_text1 = " ";

        public MainMenu()
        {
            InitializeComponent();
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            button1.BackColor = System.Drawing.Color.Transparent;
            button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Forms
            var EEform = new EEM();
            var main_menu = new MainMenu();
            combo_text1 = comboBox1.Text;
            
            if(combo_text1 == "Elektrik Elektronik Mühendisliği")
            {
                label2.Text = "Yönlendirildi: " + combo_text1;
                this.Hide();
                EEform.Show(); 
            }
            else if (combo_text1 == "")
            {
                label2.Text = "Lütfen bir bölüm seçin!";
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
