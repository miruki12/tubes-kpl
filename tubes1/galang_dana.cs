namespace tubes1
{
    public partial class galang_dana : Form
    {

        public galang_dana()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            pembayaran_galang_dana form1 = new pembayaran_galang_dana();

            // Menampilkan Form2
            form1.Show();

            // Menyembunyikan Form1
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pembayaran_galang_dana form1 = new pembayaran_galang_dana();

            // Menampilkan Form2
            form1.Show();

            // Menyembunyikan Form1
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pembayaran_galang_dana form1 = new pembayaran_galang_dana();

            // Menampilkan Form2
            form1.Show();

            // Menyembunyikan Form1
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();

            // Menampilkan Form2
            form2.Show();

            // Menyembunyikan Form1
            this.Hide();
        }
    }
}
