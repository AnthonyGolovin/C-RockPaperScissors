using System;
using System.Threading;
using System.Collections.Generic;

namespace RockPaperScissorsLogic {

    public class RPS
    {
        public string Rock;
        public string Paper;
        public string Scissors;
            
        public RPS(string rock, string paper, string scissors)
        {
            Rock = rock;
            Paper = paper;
            Scissors = scissors;
        }

        public static string Game(string Rock, string Paper, string Scissors)
        {
            string rockVic = "Victory By ROCK";
            string paperVic = "Victory By PAPER";
            string scissorVic = "Victory By SCISSORS";
            string draw = "Draw";
            string invalid = "Invalid input";
            

        if (p1 == paper && p2 == rock || p2 == paper && p1 == rock)
            {
                return paperVic;
            }

         else if (p1 == rock && p2 == scissors || p2 == rock && p1 == scissors)
            {
                return rockVic;
            }

         else if (p1 == paper && p2 == scissors || p2 == paper && p1 == scissors)
            {
                return scissorVic;
            }
         else if (p1 == p2)
            { 
                return draw;
            }
            else
            {
                return Invalid;
            }
    }   
}