using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grid MyForm2 = new Grid();
            MyForm2.ShowDialog();
            this.Show();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Binding MyForm3 = new Binding();
            MyForm3.ShowDialog();
            this.Show();
        }
    }
}
