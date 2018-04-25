using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonMasterUtility.Models
{
    public class Dice
    { 
    static Random r = new Random();

    public static int Roll(int number, int diceType, int plus = 0)
        {
            int total = plus;
            for(int i = 0; i < number; i++)
            {
                total += r.Next(diceType) + 1;
            }
            return total;
        }
    }
}