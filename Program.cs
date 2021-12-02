using System;

namespace Rps
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
            void start(){
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("Welcome, Player 1 choose rock, paper, or scissors.");
            var decision1 = Console.ReadLine();
            int player1;
            bool cmon = int.TryParse(decision1, out player1);
            if(player1 > 3 || player1 < 1 || cmon == false)
            {
                Console.WriteLine("Please pick a number between 1-3");
                start();
            }
            Console.WriteLine("Welcome, Player 2 choose rock, paper, or scissors.");
            var decision2 = Console.ReadLine();
            int player2;
            bool cmon1 = int.TryParse(decision2, out player2);
            if(player2 > 3 || player2 < 1 || cmon1 == false)
            {
                Console.WriteLine("Please pick a number between 1-3");
                start();
            }
            RPS(player1, player2);
            int RPS(int player1, int player2)
           {
               Console.WriteLine($"Player 1: {player1}");
               Console.WriteLine($"Player 2: {player2}");
               if(player1 == 1 && player2 == 3)
               {
                   Console.WriteLine("Player 1 wins");
                   start();
               }
               else if(player1 == 1 && player2 == 2)
               {
                   Console.WriteLine("Player 2 wins");
                   start();
               }
               else if(player1 == 1 && player2 == 1)
               {
                   Console.WriteLine("Draw");
                   start();
               }
               else if(player1 == 2 && player2 == 1)
               {
                   Console.WriteLine("Player 1 wins");
                   start();
               }
               else if(player1 == 2 && player2 == 2)
               {
                   Console.WriteLine("Draw");
                   start();
               }
               else if(player1 == 2 && player2 == 3)
               {
                   Console.WriteLine("Player 2 wins");
                   start();
               }
               else if(player1 == 3 && player2 == 1)
               {
                   Console.WriteLine("Player 2 wins");
                   start();
               }
               else if(player1 == 3 && player2 == 2)
               {
                   Console.WriteLine("Player 2 wins");
                   start();
               }
               else if(player1 == 3 && player2 == 3)
               {
                   Console.WriteLine("Draw");
                   start();
               }
               return player1;
           }
          }
        }
    }
}