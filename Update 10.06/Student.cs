﻿using System;
using System.Windows;

namespace SPNZ
{
    public class Student : Event
    {
        //Zmienne
        //Statystyki
        private static int energia;
        private static int chec_do_zycia;
        private static int trzezwosc_umyslu;
        private static int wiedza;
        private static int wspolpraca;

        //Zegar
        private static int godzina;
        private static int minuta;
        private static int dzien;
        private static string dzientygodnia;

        public static void InicjalizacjaGracza()
        {
            energia = 100;
            chec_do_zycia = 100;
            trzezwosc_umyslu = 100;
            wiedza = 10;
            wspolpraca = 0;

            godzina = 7;
            minuta = 0;
            dzien = 1;
            dzientygodnia = "Poniedziałek";

            kolokwium = 1;
            liczba_odwiedzin = 0;
        }

        public static int Energia()
        {
            return energia;
        }
        public static int Checi()
        {
            return chec_do_zycia;
        }
        public static int Trzezwosc()
        {
            return trzezwosc_umyslu;
        }
        public static int Wiedza()
        {
            return wiedza;
        }
        public static int Wspolpraca()
        {
            return wspolpraca;
        }
        public static int Kolos()
        {
            return kolokwium;
        }
        public static int Odwiedziny()
        {
            return liczba_odwiedzin;
        }

        public static void ZmianaEnergia(int zmiana)
        {
            if (energia + zmiana > 100)
            {
                energia = 100;
            }
            else if (energia + zmiana <= 0)
            {
                energia = 0;
            }
            else
            {
                energia += zmiana;
            }
        }
        public static void ZmianaCheci(int zmiana)
        {
            if (chec_do_zycia + zmiana > 100)
            {
                chec_do_zycia = 100;
            }
            else if (chec_do_zycia + zmiana <= 0)
            {
                chec_do_zycia = 0;
            }
            else
            {
                chec_do_zycia += zmiana;
            }
        }
        public static void ZmianaTrzezwosc(int zmiana)
        {
            if (trzezwosc_umyslu + zmiana > 100)
            {
                trzezwosc_umyslu = 100;
            }
            else if (trzezwosc_umyslu + zmiana <= 0)
            {
                trzezwosc_umyslu = 0;
            }
            else
            {
                trzezwosc_umyslu += zmiana;
            }
        }
        public static void ZmianaWiedza(int zmiana)
        {
            if (wiedza + zmiana > 100)
            {
                wiedza = 100;
            }
            else if (wiedza + zmiana <= 0)
            {
                wiedza = 0;
            }
            else
            {
                wiedza += zmiana;
            }
        }
        public static void ZmianaWspolpraca(int zmiana)
        {
            if (wspolpraca + zmiana > 100)
            {
                wspolpraca = 100;
            }
            else if (wspolpraca + zmiana <= 0)
            {
                wspolpraca = 0;
            }
            else
            {
                wspolpraca += zmiana;
            }
        }
        public static void ZmianaKolokwium()
        {
            if (dzien == 9)
            {
                kolokwium = 2;
            }
            else if(dzien==16)
            {
                kolokwium = 3;
            }
            else if(dzien==23)
            {
                kolokwium = 4;
            }
            else
            {

            }
        }
        public static void ZmianaStatystyk()
        {
            if (dzien == 8)
            {
                ZmianaCheci(-20);
                ZmianaWiedza(-25);
                ZmianaWspolpraca(-25);
            }
            else if (dzien == 15)
            {
                ZmianaCheci(-20);
                ZmianaWiedza(-25);
                ZmianaWspolpraca(-25);
            }
            else if (dzien == 22)
            {
                ZmianaCheci(-20);
                ZmianaWiedza(-25);
                ZmianaWspolpraca(-25);
            }
            else
            {

            }
        }
        public static void Psycha()
        { 
            if((dzien == 8) || (dzien == 15) || (dzien == 22))
            {
                if (liczba_odwiedzin < 5)
                {
                    MessageBox.Show("Za mało się integrujesz \n Poziom chęci do życia spada (-50) oraz poziom energii spada (-30)", "Wyspa", MessageBoxButton.OK, MessageBoxImage.Warning);
                    ZmianaCheci(-50);
                    ZmianaEnergia(-30);
                    liczba_odwiedzin = 0;
                }
                else
                {
                    liczba_odwiedzin = 0;
                }
            }
        }
        public static void Psychika()
        {
            if(chec_do_zycia==0)
            {
                ZmianaGodzina(24);
                ZmianaCheci(100);
                ZmianaEnergia(100);
                MessageBox.Show("Poziom twojej psychiki spadł do 0 \n Potrzebujesz odpoczynku (+24h)", "Psycha is sitting", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }




        public static int Godzina()
        {
            return godzina;
        }
        public static int Minuta()
        {
            return minuta;
        }
        public static int Dzien()
        {
            return dzien;
        }

        public static void ZmianaGodzina(int zmiana)
        {
           godzina += zmiana;
           if (godzina >= 24)
           {
                godzina -= 24;
                dzien++;
           }
        }
        public static void ZmianaMinuta(int zmiana)
        {
            minuta += zmiana;
            if (minuta >= 60)
            {
                minuta -= 60;
                godzina++;
            }
        }
        public static string DzienTygodnia()
        {
            var d = Dzien();
            if(d % 7 == 6)
            {
                dzientygodnia = "Sobota";
                return dzientygodnia;
            }
            else if(d % 7 == 5)
            {
                dzientygodnia = "Piątek";
                return dzientygodnia;
            }
            else if (d % 7 == 4)
            {
                dzientygodnia = "Czwartek";
                return dzientygodnia;
            }
            else if (d % 7 == 3)
            {
                dzientygodnia = "Środa";
                return dzientygodnia;
            }
            else if (d % 7 == 2)
            {
                dzientygodnia = "Wtorek";
                return dzientygodnia;
            }
            else if (d % 7 == 1)
            {
                dzientygodnia = "Poniedziałek";
                return dzientygodnia;
            }
            else
            {
                dzientygodnia = "Niedziela";
                return dzientygodnia;
            }
        }
    }
}