using System;
using System.Globalization;
using System.Threading;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            int countW = 0;
            int countS = 0;
            int countA = 0;
            int countD = 0;

            Perks myPerks = 0;
            
            foreach (char perkLetra in args[0])
            {
                if(perkLetra == 'w')
                {
                    countW++;
                }
                else if(perkLetra == 's')
                {
                    countS++;
                }
                else if(perkLetra == 'a')
                {
                    countA++;
                }
                else if(perkLetra == 'd')
                {
                    countD++;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
            }

            if(countW % 2 != 0)
            {
                myPerks = Perks.WaterBreathing | myPerks;
            }

            if(countS % 2 != 0)
            {
                myPerks = Perks.Stealth | myPerks;
            }

            if(countA % 2 != 0)
            {
                myPerks = Perks.AutoHeal | myPerks;
            }

            if(countD % 2 != 0)
            {
                myPerks = Perks.DoubleJump | myPerks;
            }

            if(myPerks != 0)
            {
                Console.WriteLine(myPerks);
                if((myPerks & Perks.Stealth) == Perks.Stealth & 
                (myPerks & Perks.DoubleJump) == Perks.DoubleJump )
                {
                    Console.WriteLine("Silent jumper!");
                }
                if((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
            if(myPerks == 0)
            {
                Console.WriteLine("No perks at all");
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
