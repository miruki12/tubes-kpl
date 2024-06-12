namespace tubes1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu _menu = new menu();

            _menu.Show();

            this.Hide();
        }
    }
}