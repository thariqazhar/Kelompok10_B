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
    public partial class Grid : Form
    {
        public Grid()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet1.kamar' table. You can move, or remove it, as needed.
            this.kamarTableAdapter.Fill(this.hotelDataSet1.kamar);
            // TODO: This line of code loads data into the 'hotelDataSet.karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.hotelDataSet.karyawan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
