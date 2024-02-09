using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactor
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int I = 1;
                while (I==1)
            {
                ReactorWarningLabel1.BackColor = Color.White;
                ReactorWarningLabel2.BackColor = Color.White;
                TitleBackground.Text = "Reactor Disabled";
                TitleBackground.ForeColor = Color.White;
                TitleBackground.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(1000);
                ReactorWarningLabel2.BackColor = Color.Red;
                ReactorWarningLabel1.BackColor = Color.Red;
                TitleBackground.BackColor = Color.White;
                TitleBackground.ForeColor = Color.Black;
                Refresh();
                Thread.Sleep(1000);

            }
           
        }
            


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
