using System;

namespace SPNZ
{
    public class Student
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

        //Funkcjonalnosci
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
        }


        //Statystyki
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
                energia = energia + zmiana;
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
                energia = 100;
            }
            else if (trzezwosc_umyslu + zmiana <= 0)
            {
                energia = 0;
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
                wspolpraca = energia + zmiana;
            }
        }
        public static bool Zmeczenie()
        {
            if(energia==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Zegar
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
            if (godzina + zmiana >= 24)
            {
                godzina -= 24;
                dzien++;
            }
        }
        public static void ZmianaMinuta(int zmiana)
        {
            if (minuta + zmiana >= 60)
            {
                minuta -= 60;
                godzina++;
            }
        }
    }
}