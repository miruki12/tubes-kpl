using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tubes1
{
    public partial class pembayaran_donasi : Form
    {
        public pembayaran_donasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu form12 = new menu();

            // Menampilkan Form2
            form12.Show();

            // Menyembunyikan Form1
            this.Hide();
        }
    }
}
