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
            int pozar = 150; 
			if (poz.Next(0, 900) == pozar)
			{
				Student.ZmianaGodzina(8);
				Student.ZmianaCheci(-15);
				SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\XDDDD.wav");
				simplesound.Play();
				MessageBox.Show("Wybuchł pożar!!!!", "Pali się", MessageBoxButton.OK, MessageBoxImage.Warning);
				return true;
			}
			return false;
		}
		public static void Gry()
		{
			SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\amogus.wav");
			simplesound.Play();
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(30);
			Student.ZmianaGodzina(2);
			Student.ZmianaTrzezwosc(5);

		}
		public static void Discord()
		{
			SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\discord.wav");
			simplesound.Play();
			Student.ZmianaEnergia(-10);
			Student.ZmianaCheci(10);
			Student.ZmianaWspolpraca(5);
			Student.ZmianaGodzina(2);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Etrapez()
		{
			SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\etrapez.wav");
			simplesound.Play();
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(-15);
			Student.ZmianaGodzina(2);
			Student.ZmianaWiedza(25);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Zajecia()
		{
			SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\teams.wav");
			simplesound.Play();
			Student.ZmianaEnergia(-30);
			Student.ZmianaCheci(-20);
			Student.ZmianaGodzina(3);
			Student.ZmianaWiedza(40);
		}
		public static void Spij()
		{
			//SoundPlayer simplesound = new SoundPlayer(@"C:\Users\Zielony\Desktop\STUDIA\Elektronika 2 semestr\Programowanie obiektowe\SPNZ\chrapanie.wav");
			//simplesound.Play();
			Student.ZmianaEnergia(30);
			Student.ZmianaGodzina(7);
			Student.ZmianaCheci(20);
			Student.ZmianaTrzezwosc(20);
		}
	}
}