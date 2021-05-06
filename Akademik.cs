using System;

namespace SPNZ
{
	public class Akademik
	{
		int Pozar()
        {
			return 0;
        }
		int Gry()
        {
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(30);
			Student.ZmianaGodzina(2);
			return 0;
        }
		void Discord()
        {
			Student.ZmianaEnergia(-10);
            Student.ZmianaCheci(10);
			Student.ZmianaWspolpraca(5);
            Student.ZmianaGodzina(2);
        }
		void Etrapez()
        {
			Student.ZmianaEnergia(-20);
			Student.ZmianaCheci(-15);
			Student.ZmianaGodzina(2);
			Student.ZmianaWiedza(25)
			
        }
		void Zajecia()
        {
			Student.ZmianaEnergia(-30);
			Student.ZmianaCheci(-20);
			Student.ZmianaGodzina(3);
			Student.ZmianaWiedza(40)
			
        }
		void Grupka()
        {
			if (Student.Wspolpraca => 100)
			{ 
				Student.ZmianaWiedza(150);
				Student.ZmianaCheci(50);
			}
        }

		void Spij()
        {
			
        }
	}
}
