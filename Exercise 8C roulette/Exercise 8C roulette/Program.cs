using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8C_roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Bets bets = new Bets();
            NumberGenerator numbergenerator = new NumberGenerator();
            Result result = numbergenerator.Randnum();

            

            if (result.Number == 0)
            {
                Console.WriteLine("you won a green bet with 0");
                
            }
            else if (result.Number == 37)
            {
                Console.WriteLine("you won a green bet with 00");
            }
            else
            {
                Console.WriteLine($"Landed on {result.Color} {result.Number}");
                bets.indnum(result);
            bets.evenodds(result);
            bets.colorbet(result);
            bets.lowhighbet(result);
            bets.dozens(result);
            bets.columns(result);
            bets.street(result);
            bets.corner(result);
            bets.doublerows(result);
            bets.split(result);
            }

           

            Console.ReadLine();
        }
    }
}
