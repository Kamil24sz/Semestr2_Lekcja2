using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćwiczenie
{
    public class Silink
    {
        public bool CzyWlaczony;

        private int moc;

        public void ZwiekszMoc(int wartosc)
        {
            if (CzyWlaczony == true)
            {

                if (wartosc < 200)
                    moc = wartosc;

                Console.WriteLine("Obecna moc to " + moc);
            }
            else
            {
                Console.WriteLine("Nie można wykonać operacji, ponieważ silink jest wyłączony");
            }
        }

        /*
         Zadanie domowe

        Zadanie: Napisać aplikację konsolową, której zadaniem będzie zasymulowanie picia
        wody z butelki. W projekcie należy stworzyć klasę Butelka, która powinna mieć
        własności (TypNapoju, AktualnaIloscNapoju) oraz metody (Wypij, SprawdzIlosc)
        ● Metoda Wypij powinna przyjmować ilość napoju do wypicia i jej zadaniem jest
        wyświetlenie informacji na konsoli o wypiciu napoju oraz zmniejszenie
        aktualnej jego ilości w butelce
        ● Metoda SprawdźIlość powinna wypisywać na konsole, ile napoju zostało
        jeszcze w butelce

        ● Jeżeli nastąpi próba wypicia większej ilości napoju niż znajduje się aktualnie w
        butelce powinien pojawić się komunikat o braku możliwości wypicia napoju.

         */

    }
}
