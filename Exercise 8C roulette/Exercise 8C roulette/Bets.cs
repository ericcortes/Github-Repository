using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8C_roulette
{
    class Bets 
    {
       NumberGenerator numbergenerator = new NumberGenerator();

        public int[] columnone = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};
        public int[] columntwo = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] columnthree = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };


        public string indnum(Result result)
        {
            Console.WriteLine($"you won the individual number bet with {result.Number}");
           
            return "result";
        }
       
        public string evenodds(Result result)
        {
            if (result.Number%2 == 0 )
            {
                Console.WriteLine("you won an even number bet");
                //return "you win an even number bet";
                return "result";
            }
            else
            {
                Console.WriteLine("you won an odd number bet");
                //return "you win an odd number bet";
                return "result";
            }

            
        }

        public string colorbet(Result result)
        {
            if (result.Number == 0) { return String.Empty; }
            Console.WriteLine($"you won a {result.Color} bet");
            //return result.Color;
            return "result";
        }
        
        public string lowhighbet(Result result)
        {
            if(result.Number < 13)
            {
                Console.WriteLine("you won a low bet");
            }
            else
            {
                Console.WriteLine("you won a high bet");
            }
            return "result";
        }

        public string dozens(Result result)
        {
            if(result.Number < 12)
            {
                Console.WriteLine("you won a first dozen bet");
            }
            else if(result.Number > 12 && result.Number < 24)
            {
                Console.WriteLine("you won a second dozen bet");
            }
            else
            {
                Console.WriteLine("you won a third dozen bet");
            }
            return "result";
        }

        public string columns(Result result)
        {
            for(int i = 0; i < columnone.Length; i++)            
            {
                if(result.Number == columnone[i])
                {
                    Console.WriteLine("Column 1 won this bet");
                }
                if (result.Number == columntwo[i])
                {
                    Console.WriteLine("Column 2 won this bet");
                }
                if (result.Number == columnthree[i])
                {
                    Console.WriteLine("Column 3 won this bet");
                }
            }
          
            return "result";
        }

        public string street(Result result)
        {
            for (int i = 0; i < columnone.Length; i++)
            {
                if(result.Number == columnone[i])
                {
                    Console.WriteLine($"you won a street bet with {result.Number}, {result.Number + 1}, {result.Number + 2}");
                }
                if (result.Number == columntwo[i])
                {
                    Console.WriteLine($"you won a street bet with {result.Number - 1}, {result.Number}, {result.Number + 1}");
                }
                if (result.Number == columnthree[i])
                {
                    Console.WriteLine($"you won a street bet with {result.Number - 2}, {result.Number - 1}, {result.Number}");
                }
            }                
                return "result";
        }

        public string corner(Result result)
        {
            for (int i = 0; i < columnone.Length; i++)
            {
                if (result.Number == columnone[i])
                {                               
                    if(result.Number == 1)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number}, {result.Number + 1}, {result.Number + 3}, {result.Number + 4}");
                    }
                    else if(result.Number == 34)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 3}, {result.Number - 2}, {result.Number}, {result.Number + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a corner bet with either {result.Number}, {result.Number + 1}, {result.Number + 3}, {result.Number + 4}" +
                       $" or {result.Number - 3}, {result.Number - 2}, {result.Number}, {result.Number + 1}");
                    }
                }


                if (result.Number == columntwo[i])
                {                   
                    if(result.Number == 2)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 1}, {result.Number}, {result.Number + 2}, {result.Number + 3} or " +
                            $"{result.Number}, {result.Number + 1}, {result.Number + 3}, {result.Number + 4}");
                    }
                    else if(result.Number == 35)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 4}, {result.Number - 3}, {result.Number - 1}, {result.Number }" +
                            $" or {result.Number - 3}, {result.Number - 2}, {result.Number}, {result.Number + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a corner bet with either {result.Number - 4}, {result.Number - 3}, {result.Number - 1}, {result.Number }" +
                       $" or {result.Number - 3}, {result.Number - 2}, {result.Number}, {result.Number + 1} or " +
                       $"{result.Number - 1}, {result.Number}, {result.Number + 2}, {result.Number + 3} or " +
                       $"{result.Number}, {result.Number + 1}, {result.Number + 3}, {result.Number + 4}");
                    }
                }


                if (result.Number == columnthree[i])
                {                  
                    if(result.Number == 3)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 1}, {result.Number}, {result.Number + 2}, {result.Number + 3}");
                    }
                    else if(result.Number == 36)
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 4}, {result.Number - 3}, {result.Number - 1}, {result.Number }");
                    }
                    else
                    {
                        Console.WriteLine($"you won a corner bet with {result.Number - 4}, {result.Number - 3}, {result.Number - 1}, {result.Number }" +
                        $" or {result.Number - 1}, {result.Number}, {result.Number + 2}, {result.Number + 3}");
                    }
                }
            }
            return "result";           
        }

        public string doublerows(Result result)
        {
            for (int i = 0; i < columnone.Length; i++)
            {
                if (result.Number == columnone[i])
                {                  
                    if (result.Number == 1)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number}, {result.Number + 1}, {result.Number + 2}, {result.Number + 3}, " +
                            $"{result.Number + 4}, {result.Number + 5}");
                    }
                    else if (result.Number == 34)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 3}, {result.Number - 2}, {result.Number - 1}, {result.Number}, " +
                        $"{result.Number + 1}, {result.Number + 2}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 3}, {result.Number - 2}, {result.Number - 1}, {result.Number}, " +
                        $"{result.Number + 1}, {result.Number + 2} or {result.Number}, {result.Number + 1}, {result.Number + 2}, {result.Number + 3}, " +
                        $" {result.Number + 4}, {result.Number + 5}");
                    }
                }
                if (result.Number == columntwo[i])
                {                  
                    if (result.Number == 2)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 1}, {result.Number}, {result.Number + 1}, {result.Number + 2}, " +
                            $"{result.Number + 3}, {result.Number + 4}");
                    }
                    else if (result.Number == 35)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 4}, {result.Number - 3}, {result.Number - 2}, {result.Number - 1}, " +
                        $"{result.Number}, {result.Number + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 4}, {result.Number - 3}, {result.Number - 2}, {result.Number - 1}, " +
                        $"{result.Number}, {result.Number + 1} or {result.Number - 1}, {result.Number}, {result.Number + 1}, {result.Number + 2}, " +
                        $" {result.Number + 3}, {result.Number + 4}");
                    }
                   
                }
                if (result.Number == columnthree[i])
                {
                  
                    if (result.Number == 3)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 2}, {result.Number - 1}, {result.Number}, {result.Number + 1}, " +
                            $"{result.Number + 2}, {result.Number + 3}");
                    }
                    else if (result.Number == 36)
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 5}, {result.Number - 4}, {result.Number - 3}, {result.Number - 2}, " +
                        $"{result.Number - 1}, {result.Number}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a double rows bet with {result.Number - 5}, {result.Number - 4}, {result.Number - 3}, {result.Number - 2}, " +
                        $"{result.Number - 1}, {result.Number} or {result.Number - 2}, {result.Number - 1}, {result.Number}, {result.Number + 1}, " +
                        $" {result.Number + 2}, {result.Number + 3}");
                    }
                }
            }
                return "result";
        }

        public string split(Result result)
        {
            for (int i = 0; i < columnone.Length; i++)
            {
                if (result.Number == columnone[i])
                {                  
                    if (result.Number == 1)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number}, {result.Number + 1} or {result.Number}, {result.Number + 3}");
                    }
                    else if (result.Number == 34)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number} or {result.Number}, {result.Number + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number}, or {result.Number}, {result.Number + 1}, " +
                        $"or {result.Number}, {result.Number + 3}");
                    }
                }
                if (result.Number == columntwo[i])
                {                  
                    if (result.Number == 2)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 1}, {result.Number} or {result.Number}, {result.Number + 1} or" +
                            $"{result.Number}, {result.Number + 3}");
                    }
                    else if (result.Number == 35)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number} or {result.Number}, {result.Number + 1}" +
                            $" or {result.Number - 1}, {result.Number}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number} or {result.Number - 1}, {result.Number}, or" +
                        $" {result.Number}, {result.Number + 1} or {result.Number}, {result.Number + 3}");
                    }
                }
                if (result.Number == columnthree[i])
                {
                   
                    if (result.Number == 3)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 1}, {result.Number} or {result.Number}, {result.Number + 3}");
                    }
                    else if (result.Number == 36)
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number} or {result.Number}, {result.Number - 1}");
                    }
                    else
                    {
                        Console.WriteLine($"you won a split bet with {result.Number - 3}, {result.Number}, or {result.Number}, {result.Number + 3}, " +
                        $"or {result.Number - 1}, {result.Number}");
                    }
                }
            }
            return "result";
        }
    }
}
