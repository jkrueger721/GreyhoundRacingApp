using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreyHoundRaceTrackSim
{
   public class Bet
    {
        public int Amount; // The amount of Cash that was bet 
        public int Dog; // The number of dog the bet is on 
        public Guy Bettor; // The guy who placed the bet 

        public string GetDescription()
        {
            // Return a string that says who placed the bet, how much 
            // cash was bet, and which dog he bet on ("Joe bet 8 on
            // dog #4"). If the amount is zero, no bet was placed
            //("Joe hasn't place a bet.").

        }
        public int Payout (int Winner)
        {
            //The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the regative of 
            // the amount bet. 
        }
    }
}
