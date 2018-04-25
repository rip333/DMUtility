using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonMasterUtility.Models
{
    public class Encounter
    {
        private Random r = new Random();

        public string generateVolcanoEncounter()
        {
            return volcanoEncounters.ElementAt(r.Next(volcanoEncounters.Count));
        }

        List<String> volcanoEncounters = new List<string>
        {
            string.Format("{0} Charred Priest(s), {1} Charred Guardian(s)", Dice.Roll(1,2), Dice.Roll(1,4)),
            string.Format("{0} Charred Priest(s), {1} Charred Guardian(s)", Dice.Roll(1,2), Dice.Roll(1,4)),
            string.Format("Flamewrath, {0} Charred Guardian(s)", Dice.Roll(1,5)),
            string.Format("Flamewrath, {0} Charred Guardian(s)", Dice.Roll(1,5)),
            string.Format("Razerblast, {0} Charred Guardian(s)", Dice.Roll(1,5)),
            string.Format("Razerblast, {0} Charred Guardian(s)", Dice.Roll(1,5)),
            string.Format("{0} Firegeist(s)", Dice.Roll(2, 4)),
            "Hellforged Golem",
            "2 hellhounds",
            "Salamander, 2 Fire Snakes", "Salamander, 2 Fire Snakes",
            "Nothing", "Nothing", "Nothing", "Nothing"
        };
    }
}