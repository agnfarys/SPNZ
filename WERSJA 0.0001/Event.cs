﻿using System;
using System.Media;
using System.Windows;

namespace SPNZ
{
    public class Event
    {
        protected static int kolokwium;
        protected static int liczba_odwiedzin;
        private static int zaliczenie;

        public static void ZmianaOdwiedzin()
        {
            liczba_odwiedzin++;
        }
        //Wyspa
        public static void Piwo()
        {
            SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\piwo.wav");
            simplesound.Play();
            Student.ZmianaEnergia(-10);
            Student.ZmianaCheci(15);
            Student.ZmianaTrzezwosc(-10);
            Student.ZmianaGodzina(1);

        }

        public static void Flany()
        {
            //energia-,czas-,chec++,trzezwosc--,wspolpraca+
            Student.ZmianaEnergia(-25);
            Student.ZmianaCheci(15);
            Student.ZmianaGodzina(1);
            Student.ZmianaTrzezwosc(-25);
            Student.ZmianaWspolpraca(4);
        }

        public static void Integracja()
        {
            //czas(-noc),energia--,chec+++,trzezwosc---,wspolpraca++
            Student.ZmianaEnergia(-50);
            Student.ZmianaCheci(60);
            Student.ZmianaTrzezwosc(-60);
            Student.ZmianaWspolpraca(10);
            Student.ZmianaGodzina(18);
        }

        public static bool Interwencja()
        {
            Random rnd = new Random();
            int trzezwy = Student.Trzezwosc();
            //if (rnd.Next(0, 750) <= trzezwy)
                if (rnd.Next(0, 2) == 1)
                {
                Student.ZmianaGodzina(24);
                Student.ZmianaTrzezwosc(100);
                Student.ZmianaCheci(-70);
                Student.ZmianaEnergia(-20);
                SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\wasted.wav");
                simplesound.Play();
                MessageBox.Show("Policja!!! Jedziesz z nami na wytrzeźwiałke", "Policja", MessageBoxButton.OK, MessageBoxImage.Warning);
                return true;
            }
            return false;
        }


        //Zaliczenie
        public static void Kolokwium()
        {
            zaliczenie++;
        }

        void Egzamin()
        {

        }
    }
}
