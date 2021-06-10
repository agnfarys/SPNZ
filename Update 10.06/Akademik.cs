using System;
using System.Media;
using System.Windows;
using System.Windows.Media;

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
				MediaPlayer mplayer = new MediaPlayer();
				mplayer.Open(new Uri("XDDDD.wav", UriKind.Relative));
				mplayer.Play();
				MessageBox.Show("Wybuchł pożar!!!!", "Pali się", MessageBoxButton.OK, MessageBoxImage.Warning);
				return true;
			}
			return false;
		}
		public static void Gry()
		{
			MediaPlayer mplayer = new MediaPlayer();
			mplayer.Open(new Uri("amogus.wav", UriKind.Relative));
			mplayer.Play();
			Student.ZmianaEnergia(-15);
			Student.ZmianaCheci(3);
			Student.ZmianaGodzina(3);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Discord()
		{
			MediaPlayer mplayer = new MediaPlayer();
			mplayer.Open(new Uri("discord.wav", UriKind.Relative));
			mplayer.Play();
			Student.ZmianaEnergia(-15);
			Student.ZmianaCheci(5);
			Student.ZmianaWspolpraca(2);
			Student.ZmianaGodzina(3);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Etrapez()
		{
			MediaPlayer mplayer = new MediaPlayer();
			mplayer.Open(new Uri("etrapez.wav", UriKind.Relative));
			mplayer.Play();
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(-10);
			Student.ZmianaGodzina(4);
			Student.ZmianaWiedza(5);
			Student.ZmianaTrzezwosc(5);
		}
		public static void Zajecia()
		{
			MediaPlayer mplayer = new MediaPlayer();
			mplayer.Open(new Uri("teams.wav", UriKind.Relative));
			mplayer.Play();
			Student.ZmianaEnergia(-30);
			Student.ZmianaCheci(-20);
			Student.ZmianaGodzina(6);
			Student.ZmianaWiedza(10);
		}
		public static void Spij()
		{
			MediaPlayer mplayer = new MediaPlayer();
			mplayer.Open(new Uri("chrapanie.wav", UriKind.Relative));
			mplayer.Play();
			Student.ZmianaEnergia(30);
			Student.ZmianaGodzina(6);
			Student.ZmianaCheci(12);
			Student.ZmianaTrzezwosc(15);
		}
	}
}