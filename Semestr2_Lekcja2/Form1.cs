using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semestr2_Lekcja2.Klasy;

namespace Semestr2_Lekcja2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            // zmienna na poprawne login i hasło
            string poprawnyLogin = "gigant";
            string poprawneHaslo = "gigant123";

            //tworzenie użytkownika
            Uzytkownik user = new Uzytkownik();

            //nadawanie wartości właściwością użytkownika
            user.Login = "gigant";
            user.Haslo = "haslo";
            user.Wiek = 16;
            user.Email = "gigant@gmail.com";

            //wywołanie funkcji przedstaw się z klasy u użytkonika
            user.PrzedstawSie();

            // sprawdzamy czy login i hasło podane przez użytkownika są poprawne
            if(tbLogin.Text == user.Login && tbHaslo.Text == user.Haslo)
            {
                //wyskakujące okienko z informacją dla użytkownika
                MessageBox.Show("Zalogowano poprawnie", "Komunikat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login lub hasło są niepoprawne", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
