using System;
using System.Media;
using System.Windows;


namespace SPNZ
{
	public class Akademik
	{
		public static bool Pozar()
		{
			Random poz = new Random();
			int los = poz.Next(0, 1000);

			int p = 150, k=500, s=850; 

			if ((los == p) || (los==k) || (los==s))
			{
				Student.ZmianaGodzina(6);
				Student.ZmianaCheci(-20);
				Student.ZmianaEnergia(-20);
				SoundPlayer simplesound = new SoundPlayer(Properties.Resources.XDDDD);
				simplesound.Play();
				MessageBox.Show("Wybuchł pożar!!!!", "Pali się", MessageBoxButton.OK, MessageBoxImage.Warning);
				return true;
			}
			return false;
		}
		public static void Gry()
		{
			SoundPlayer simplesound = new SoundPlayer(Properties.Resources.amogus);
			simplesound.Play();
			Student.ZmianaEnergia(-15);
			Student.ZmianaCheci(3);
			Student.ZmianaGodzina(3);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Discord()
		{
			SoundPlayer simplesound = new SoundPlayer(Properties.Resources.discord);
			simplesound.Play();
			Student.ZmianaEnergia(-15);
			Student.ZmianaCheci(5);
			Student.ZmianaWspolpraca(2);
			Student.ZmianaGodzina(3);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Etrapez()
		{
			SoundPlayer simplesound = new SoundPlayer(Properties.Resources.etrapez);
			simplesound.Play();
			Student.ZmianaEnergia(-25);
			Student.ZmianaCheci(-15);
			Student.ZmianaGodzina(4);
			Student.ZmianaWiedza(3);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Zajecia()
		{
			SoundPlayer simplesound = new SoundPlayer(Properties.Resources.teams);
			simplesound.Play();
			Student.ZmianaEnergia(-40);
			Student.ZmianaCheci(-25);
			Student.ZmianaGodzina(5);
			Student.ZmianaWiedza(7);
		}
		public static void Spij()
		{
			SoundPlayer simplesound = new SoundPlayer(Properties.Resources.chrapanie);
			simplesound.Play();
			Student.ZmianaEnergia(30);
			Student.ZmianaGodzina(6);
			Student.ZmianaCheci(10);
			Student.ZmianaTrzezwosc(10);
		}
	}
}