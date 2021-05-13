using System;

namespace SPNZ
{
    public class Event
    {
        bool dostepnosc;
        int liczba_odwiedzin;
        int zaliczenie;

        //Wyspa
        void Piwo()
        {
            //czas-, energia-,chec+,trzezwosc-;
            Student.ZmianaEnergia(-10);
            Student.ZmianaCheci(15);
            Student.ZmianaTrzezwosc(-10);
            Student.ZmianaGodzina(1);

        }

        void Flany()
        {
            //energia-,czas-,chec++,trzezwosc--,wspolpraca+
            Student.ZmianaEnergia(-25);
            Student.ZmianaCheci(15);
            Student.ZmianaGodzina(1);
            Student.ZmianaTrzezwosc(-25);
            Student.ZmianaWspolpraca(4);
        }

        void Integracja()
        {
            //czas(-noc),energia--,chec+++,trzezwosc---,wspolpraca++
            Student.ZmianaEnergia(-50);
            Student.ZmianaCheci(60);
            Student.ZmianaTrzezwosc(-60);
            Student.ZmianaWspolpraca(10);
            Student.ZmianaGodzina(18);
        }

        void Interwencja()
        {
            Random rnd = new Random();

            int trzezwy = Student.Trzezwosc();
            if (rnd.Next(0,50) >= trzezwy)
            {
                Console.WriteLine("Zostales zatrzymany");
                Student.ZmianaGodzina(38);
                Student.ZmianaTrzezwosc(100);
                Student.ZmianaCheci(-70);
                Student.ZmianaEnergia(-20);
            }
        }


        //Zaliczenie
        void Kolokwium()
        {

        }

        void Egzamin()
        {

        }
    }
}
