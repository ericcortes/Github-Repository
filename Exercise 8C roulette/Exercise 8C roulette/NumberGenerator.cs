using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8C_roulette
{
    public class Result
    {
        public string Color {get;set; }
        public int Number { get; set; }
    }

    public class NumberGenerator
    {
        public int result;

        public Result Randnum()
        {
            Bets bets = new Bets();
            Result result = new Result();
           
            int[] rednumber = new int[] { 0, 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] blacknumber = new int[] { 37, 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
           
            int[] color = new int[] { 1, 2 };

            Random random = new Random();

            int selection = random.Next(color.Length);
            int red = rednumber[random.Next(0, rednumber.Length)];
            int black = blacknumber[random.Next(0, blacknumber.Length)];

            if (selection == 0)
            {                
                result.Color = "Red";
                result.Number = red;
            }
            else
            {                
                result.Color = "Black";
                result.Number = black;
            }
            
            if (result.Number == 0)
            {
                result.Color = "Green";
            }
            if (result.Number == 37)
            {
                result.Color = "Green";
            }
            return result;
            
           
        }
    }
}
