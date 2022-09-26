using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja2.Klasy
{

    // programownaie obiektowe - koncepcja dzięki której opisujemy przedmioty tak jak w świecie rzeczywistym
    public class Uzytkownik
    {
        //właściwości klasy
        public string Login;
        public string Haslo;
        public int Wiek;
        public string Email;
        private int licznik;

        //modyfikatory dostępu

        //public - element jest dostępny w klasie bazaowej oraz poza nią - wszędzie
        //private - element jest dostępny tylko wewnątrz klasy bazowej

        //protected - element jest dostępny w klasie bazowej oraz dziedzicząctch z niej
        //internal - element jest dostępny wszędzie w ramach tego samego projektu


        //metoda która służy do wypisywania informacji o użytkowniku
        public string PrzedstawSie()
        {
            string tekst = "Mój login to " + Login + ", mam " + Wiek + ", mój email to: " + Email;
            return tekst;
        }
    }
}
