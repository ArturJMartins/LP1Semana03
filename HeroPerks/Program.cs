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
            
            for (int i = 0; i < args.Length; i++)
            {
                if(args[i] == "w")
                {
                    countW++;
                }
                else if(args[i] == "s")
                {
                    countS++;
                }
                else if(args[i] == "a")
                {
                    countA++;
                }
                else if(args[i] == "d")
                {
                    countD++;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    break;
                }
            }

            if(countW % 2 != 0)
            {
                myPerks = Perks.WaterBreathing;
            }

            if(countS % 2 != 0)
            {
                myPerks = Perks.Stealth;
            }

            if(countA % 2 != 0)
            {
                myPerks = Perks.AutoHeal;
            }

            if(countD % 2 != 0)
            {
                myPerks = Perks.DoubleJump;
            }

            if(myPerks != 0)
            {
                Console.WriteLine(myPerks);
            }
        }
    }
}
