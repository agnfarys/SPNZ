using System;
using System.Windows;

namespace SPNZ
{
	public class Akademik : Event
	{
		public static bool Pozar()
		{
			Random poz = new Random();
            int pozar = 150; 
			if (poz.Next(0, 700) == pozar)
			{
				Student.ZmianaGodzina(8);
				Student.ZmianaCheci(-15);
				MessageBox.Show("Wybuchł pożar!!!!", "Pali się", MessageBoxButton.OK, MessageBoxImage.Warning);
				return true;
			}
			return false;
		}
		public static void Gry()
		{
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(30);
			Student.ZmianaGodzina(2);

		}
		public static void Discord()
		{
			Student.ZmianaEnergia(-10);
			Student.ZmianaCheci(10);
			Student.ZmianaWspolpraca(5);
			Student.ZmianaGodzina(2);
		}
		public static void Etrapez()
		{
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(-15);
			Student.ZmianaGodzina(2);
			Student.ZmianaWiedza(25);
		}
		public static void Zajecia()
		{
			Student.ZmianaEnergia(-30);
			Student.ZmianaCheci(-20);
			Student.ZmianaGodzina(3);
			Student.ZmianaWiedza(40);
		}


		public static void Grupka()
		{
			int w = Student.Wiedza();
			
			if (kolokwium == 1)
			{
				if (w < 20)
				{
					int roznica = 20 - w;
					Student.ZmianaWiedza(roznica);
				}
			}
			else if(kolokwium==2)
            {
				if(w<45)
                {
					int roznica = 45 - w;
					Student.ZmianaWiedza(roznica);
                }
            }
            else
            {
				if(w<75)
                {
					int roznica = 75 - w;
					Student.ZmianaWiedza(roznica);
                }
            }
		}

		public static void Spij()
		{
			Student.ZmianaEnergia(30);
			Student.ZmianaGodzina(10);
			Student.ZmianaCheci(20);
		}
	}
}