using System;
using System.Windows;

namespace SPNZ
{
	public class Akademik
	{
		public static bool Pozar()
		{
			Random poz = new Random();
            int pozar = 150; 
			if (poz.Next(0, 800) == pozar)
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
		public static void Spij()
		{
			Student.ZmianaEnergia(30);
			Student.ZmianaGodzina(7);
			Student.ZmianaCheci(20);
		}
	}
}