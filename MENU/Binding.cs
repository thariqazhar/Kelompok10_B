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
    public partial class Binding : Form
    {
        public Binding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Binding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.hotelDataSet1.kamar);
            // TODO: This line of code loads data into the 'hotelDataSet.karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.hotelDataSet.karyawan);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
