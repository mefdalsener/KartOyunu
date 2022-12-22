using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartOyunu
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        { 
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "         ** Oyun rastgeledir **\nRastgele oyun tahtaları çözülemez olabilir.";
        }
    }
}
