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
    public partial class menu : Form
    {

        private AppState currentState = AppState.Menu;
        private Dictionary<Tuple<AppState, string>, AppState> transitionTable;
        public menu()
        {
            InitializeComponent();
            InitializeTransitionTable();
        }

        public enum AppState
        {
            Login,
            Menu,
            PembayaranDonasi,
            GalangDana
        }

        private void InitializeTransitionTable()
        {
            transitionTable = new Dictionary<Tuple<AppState, string>, AppState>
            {
                { Tuple.Create(AppState.Menu, "PembayaranDonasi"), AppState.PembayaranDonasi },
                { Tuple.Create(AppState.Menu, "GalangDana"), AppState.GalangDana },
                { Tuple.Create(AppState.Menu, "Login"), AppState.Login },
                { Tuple.Create(AppState.PembayaranDonasi, "Back"), AppState.Menu },
                { Tuple.Create(AppState.GalangDana, "Back"), AppState.Menu },
                { Tuple.Create(AppState.Login, "Back"), AppState.Menu }
            };
        }

        private void HandleTransition(string input)
        {
            AppState nextState;
            if (transitionTable.TryGetValue(Tuple.Create(currentState, input), out nextState))
            {
                TransitionToState(nextState);
            }
        }

        private void TransitionToState(AppState nextState)
        { 
            switch (nextState)
            {
                case AppState.Login:
                    ShowLoginForm();
                    break;
                case AppState.Menu:
                    ShowMenuForm();
                    break;
                case AppState.PembayaranDonasi:
                    ShowPembayarDonasiForm();
                    break;
                case AppState.GalangDana:
                    ShowGalangDanaForm();
                    break;
            }
            currentState = nextState;
        }

        private void ShowLoginForm()
        {
            login _login = new login();
            _login.Show();
            this.Hide();
        }

        private void ShowMenuForm()
        {
            this.Show();
        }

        private void ShowPembayarDonasiForm()
        {
            pembayaran_donasi _hasil = new pembayaran_donasi();
            _hasil.Show();
            this.Hide();
        }

        private void ShowGalangDanaForm()
        {
            galang_dana _galang = new galang_dana();
            _galang.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HandleTransition("PembayaranDonasi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleTransition("GalangDana");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleTransition("Login");
        }
    }
}
