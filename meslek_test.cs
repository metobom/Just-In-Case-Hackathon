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

namespace HACKATHON_2020_YTU
{
    public partial class meslek_test : Form
    {
        // variables
        int question_number = 1;
        int label_check = 0;
        int score = 0;
        int ans = 0;
        
        public meslek_test()
        {
            InitializeComponent();
            question_text.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            TEST(question_number);
        }

        private void TEST(int question_num)
        {
            switch (question_num)
            {
                // QUESTION 1
                case 1:
                    question_text.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources._1;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;

                    question_text.Text = "Bu meslekteki en önemli şeylerden biri de sürekli meraklı olmak. Görseldeki insan elektrik arklarına \n" +
                        "maruz kalmasına rağmen güvenle kafesin içinde durabiliyor. Bu tür elektriksel konulara merak duyuyor \n" +
                        "musun?";
                    button1.Text = "Merak duyuyorum.";
                    button1.Visible = true;
                    button2.Text = "Merak duymuyorum.";
                    button2.Visible = true;
                    button3.Text = "";
                    button3.Visible = false;
                    button4.Text = "";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    
                    break;
                // AFTER QUESTION 1
                case 2:
                    question_text.Visible = false;
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = true;
                    button6.Visible = false;
                    // GIVE LINKS
                    label7.Text = "Merağını daha da körükleyebileceğini düşündüğümüz bazı konular.";
                    label1.Text = "";
                    label1.Visible = true;
                    label2.Text = "Faraday kafesi nedir, ne işe yarar?";
                    label2.Visible = true;
                    label3.Text = " ";
                    label3.Visible = true;
                    label4.Text = "Faraday Kafesinin Teorisi";
                    label4.Visible = true;
                    label5.Text = " ";
                    label5.Visible = true;
                    label6.Text = "Faraday Kafesi Yapabilir Miyiz?";
                    label6.Visible = true;
                    label7.Visible = true;
                    break;
                // QUESTION 2
                case 3:
                    question_text.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources._2;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;

                    question_text.Text = "Üniversite hayatında ve projelerinde yoğunlukla devrelerle uğraşacaksın. Bu yüzden elektriksel \n" +
                        "malzemeleri kullanmayı ve birleştirmeyi öğrenmen gerekecek. Daha önce hiç hobi elektroniğiyle uğraştın \n" +
                        "mı?";
                    button1.Text = "Evet, uğraştım";
                    button1.Visible = true;
                    button2.Text = "Hayır, uğraşmadım";
                    button2.Visible = true;
                    button3.Text = "";
                    button3.Visible = false;
                    button4.Text = "";
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    ans = 4;
                    break;
                // AFTER QUESTION 2
                case 4:
                    question_text.Visible = false;
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = true;
                    button6.Visible = false;
                    // GIVE LINKS
                    label7.Text = "Her elektronikçinin devreleri eğlenerek tanıdığı ve fikirlerini proje haline getirdiği ilk elektronik öğrenme \n" +
                        "adımı: Arduino. İnternetteki sayısız kaynağı kullanarak kolayca Arduino devreleri kurmayı öğrenebilirsin.";
                    label1.Text = " ";
                    label1.Visible = true;
                    label2.Text = "Arduino İle Yapılmış Örnek Projeler";
                    label2.Visible = true;
                    label3.Text = " ";
                    label3.Visible = true;
                    label4.Text = "Arduino Eğitimi İçin";
                    label4.Visible = true;
                    label5.Text = " ";
                    label5.Visible = true;
                    label6.Text = "Diğer Elektronik Elemanlarla Yapılmış Örnek Projeler";
                    label6.Visible = true;
                    label7.Visible = true;
                    break;
                // QUESTION 3
                case 5:
                    question_text.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources._3;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;

                    question_text.Text = "Üniversitede öğrendiklerin, mesleğinde yapacaklarına temel inşa ediyor. Bu yüzden okulundaki bölüm \n" +
                        "derslerine ilgi duyman kariyerine ilk adım için çok önemli. Tahminen aşağıdaki derslerden hangileri senin \n" +
                        "bölümünde yer alıyor olabilir?";
                    button1.Text = "Kalkülüs, Fizik, Lineer Cebir ve Programlamaya Giriş";
                    button1.Visible = true;
                    button2.Text = "Devre Analizi, Dijital Sistemler ve Elektromanyetik";
                    button2.Visible = true;
                    button3.Text = "Sayısal Analiz, Olasılık ve Mikroişlemciler";
                    button3.Visible = true;
                    button4.Text = "Hepsi";
                    button4.Visible = true;
                    button5.Visible = false;
                    ans = 3;
                    break;
                // AFTER QUESTION 3
                case 6:
                    question_text.Visible = false;
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = true;
                    // GIVE LINKS
                    label7.Text = "Hepsi göreceğin dersler içinde! Elektrik elektronik mühendisliği elektromanyetik teoriden devre teorisine, \n" +
                        "yazılımdan elektrik makinelerine kadar her türlü konuyu barındırıyor. Meslek seçimini yapmadan önce, \n" +
                        "mesleğinin yapı taşlarını oluşturacak üniversite eğitimde göreceğin dersleri araştırman yüksek önem taşıyor.";
                    label1.Text = "Ders içeriklerini üniversite bölümlerinin kendi sitesinden araştırabilirsin, birkaç üniversiteden örnekler:";
                    label1.Visible = true;
                    label2.Text = "Yıldız Teknik Üniversitesi";
                    label2.Visible = true;
                    label3.Text = " ";
                    label3.Visible = true;
                    label4.Text = "ESOGU";
                    label4.Visible = true;
                    label5.Text = " ";
                    label5.Visible = true;
                    label6.Text = "ESOGÜ’de Yer Alan Laboratuvarlar";
                    label6.Visible = true;
                    label7.Visible = true;
                    break;
                    
                // QUESTION 4
                case 7:
                    question_text.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources._4;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;

                    question_text.Text = "Teknoloji dünyası sürekli genişleyen ve bir çok farklı açıdan bilgiler bulunduran bir dünya. Bu \n" +
                        "değişimlere ayak uydurabilmek için bu mesleği yapan kişilerin de sürekli öğrenmeye devam edip \n" +
                        "değişimlere ayak uydurması gerekiyor. Hayat boyunca öğrenci olmak sana neler hissettiriyor?";
                    button1.Text = "Öğrenmeyi seviyorum, hiç sorun değil.";
                    button1.Visible = true;
                    button2.Text = "Bir süre sonra öğrenmekten bıkarım.";
                    button2.Visible = true;
                    button3.Text = "";
                    button3.Visible = false;
                    button4.Text = "Hepsi";
                    button4.Visible = false;
                    button5.Visible = false;
                    ans = 3;
                    break;
                // AFTER QUESTION 4
                case 8:
                    question_text.Visible = false;
                    pictureBox1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = true;
                    button5.Text = "Bitir";
                    label7.Text = "Cevapladığın sorulara göre ilgili görünüyorsun! Sana birkaç önerimiz var! Bu mesleğe görünüyor ki ilgin \n" +
                        "büyük. Başlangıç amaçlı senin için bir yol haritası hazırladık!";
                    label1.Text = "";
                    label1.Visible = true;
                    label2.Text = "Bir üniversite ders kitabına göz at!";
                    label2.Visible = true;
                    label3.Text = " ";
                    label3.Visible = true;
                    label4.Text = "Öğrenmenin elzem olduğunu düşündüğümüz birkaç Arduino projesini öğren";
                    label4.Visible = true;
                    label5.Text = "Python programlamaya giriş yap ve basit bir proje yap!";
                    label5.Visible = true;
                    label6.Text = "İngilizceni sürekli aktif tut! İngilizce konuşmaktan korkma!";
                    label6.Visible = true;
                    label7.Visible = true;
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
            question_number++;
            TEST(question_number);
            score += 10;
            label_check++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            question_number++;
            TEST(question_number);
            score += 10;
            label_check++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            question_number++;
            TEST(question_number);
            score += 10;
            label_check++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            question_number++;
            TEST(question_number);
            score += 10;
            label_check++;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            question_number++;
            TEST(question_number);
            score += 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label_check == 1)
            {
                Process.Start("https://www.youtube.com/watch?v=V1kutBxL3Hk");
            }
            else if (label_check == 2)
            {
                Process.Start("https://www.youtube.com/playlist?list=PL1J0y2v7mkQwUAn7tqsn1VbqjfjwQlPOO");
            }
            else if (label_check == 3)
            {
                Process.Start("http://www.bologna.yildiz.edu.tr/index.php?r=program/view&id=7&aid=4");
            }
            else if (label_check == 4)
            {
                Process.Start("https://www.amazon.com/Physics-Principles-Applications-Standalone-book/dp/0321625927/ref=sr_1_1?crid=21QVXNWQCP0R&dchild=1&keywords=giancoli+physics&qid=1604758939&s=books&sprefix=giancoli+%2Cstripbooks-intl-ship%2C282&sr=1-1");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label_check == 1)
            {
                Process.Start("https://tr.wikipedia.org/wiki/Faraday_kafesi");
            }
            else if (label_check == 2)
            {
                Process.Start("https://www.youtube.com/playlist?list=PL1J0y2v7mkQzbJFmnxI-OcMH-xEGYuDCz");
            }
            else if (label_check == 3)
            {
                Process.Start("https://eee.ogu.edu.tr/Sayfa/Index/97/ders-bilgi-paketi-ders-icerikleri");
            }
            else if (label_check == 4)
            {
                Process.Start("https://www.youtube.com/watch?v=tvvEqvyh_Vw");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if(label_check == 1)
            {
                Process.Start("https://bilimgenc.tubitak.gov.tr/makale/faraday-kafesi-yapalim");
            }
            else if(label_check == 2)
            {
                Process.Start("https://www.youtube.com/user/enerji60");
            }
            else if(label_check == 3)
            {
                Process.Start("https://eee.ogu.edu.tr/Sayfa/Index/38/laboratuvarlar");
            }
            else if(label_check == 4)
            {
                Process.Start("https://www.cambly.com/english?lang=tr&lang=tr");
            }
        }
    }
}
