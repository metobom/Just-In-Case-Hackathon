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
    public partial class meslek_test : Form
    {
        // variables
        int question_number = 1;
        int score = 0;
        int ans;
        int total_question = 4;

        public meslek_test()
        {
            InitializeComponent();
            TEST(question_number);
        }

        
        private void TEST(int question_num)
        {
            switch (question_num)
            {
                case 1:
                    pictureBox1.Visible = false;
                    question_text.Text = "Çekmecende ne var?";
                    button1.Text = "Araba";
                    button2.Text = "PIC16F877A";
                    button3.Text = "Sanane";
                    button4.Text = "Bayrak";
                    ans = 1;
                    break;
                case 2:
                    pictureBox1.Visible = false;
                    question_text.Text = "Yemek yemek ister misin?";
                    button1.Text = "Hayır";
                    button2.Text = "Evet";
                    button3.Text = "Yoo";
                    button4.Text = "Hüüü";
                    ans = 4;
                    break;
                case 3:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.aaaa;
                    question_text.Text = "Resimde ne görüyorsun?";
                    button1.Text = "Sanane";
                    button2.Text = "Tır";
                    button3.Text = "Kelek";
                    button4.Text = "Ev";
                    ans = 1;
                    break;
                case 4:
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.maxresdefault;
                    question_text.Text = "Resimde ne görüyorsun?";
                    button1.Text = "blblblblb";
                    button2.Text = "HEHEHE";
                    button3.Text = "DOLAP";
                    button4.Text = "PC";
                    ans = 3;
                    break;
            }     
        }
        private void meslek_test_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == ans)
            {
                question_number++;
                TEST(question_number);
                score += 10;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == ans)
            {
                question_number++;
                TEST(question_number);
                score += 10;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == ans)
            {
                question_number++;
                TEST(question_number);
                score += 10;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == ans)
            {
                question_number++;
                TEST(question_number);
                score += 10;
            }

        }
    }
}
