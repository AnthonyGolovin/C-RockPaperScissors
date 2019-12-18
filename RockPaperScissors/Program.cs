using System;
using System.Threading;
using System.Collections.Generic;

using RockPaperScissorsLogic;

namespace RockPaperScissorsUI
{
    public class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Player 1 Select 'Rock', 'Paper' 'Scissors'");
            string p1 = Console.ReadLine().ToLower();

            Console.WriteLine("Player 2 Select 'Rock', 'Paper' 'Scissors'");
            string p2 = Console.ReadLine().ToLower();
            RPS user = new RPS(p1, p2);
            Console.WriteLine(user.Game());
                
        }
    }
}