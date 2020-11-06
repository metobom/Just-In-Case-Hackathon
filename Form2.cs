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
    public partial class EEM : Form
    {
        public EEM()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            //textBox1.ScrollBars = ScrollBars.Both();
        }

        private void EEM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var meslek_testFORM = new meslek_test();
            meslek_testFORM.Show();
        }
    }
}
