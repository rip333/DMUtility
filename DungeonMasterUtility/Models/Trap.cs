using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonMasterUtility.Models
{
    public class Trap
    {
        private Random r = new Random();

        public string generateVolcanoTrap()
        {
            return volcanoTraps.ElementAt(r.Next(volcanoTraps.Count));
        }

        private List<string> volcanoTraps = new List<string>
        {
            string.Format("CRUST BREAK: A random character ({0}) steps on a particularly thin spot on the floor. "
                 + "The character must succeed on a DC 10 DEX Saving throw or fall into a hole {1}0 feet deep.  ({2}) - on a 4 the hole contains lava, dealing {3} fire damage",
                Dice.Roll(1,4), Dice.Roll(1,4), Dice.Roll(1,4), Dice.Roll(2,10)),
            string.Format("FLAME GOUT: A bubble of gas spontaneously ignites, creating a burst of flame dealing {0} fire damge", Dice.Roll(2, 6)),
            string.Format("LAVA RAIN: At the start of each round, lava droplets form on the ceiling and fall in a 20 ft diameter area, dealing {0} fire damage" +
                " to any creature that enters/starts it's turn in the area.  The rain ends {1} turns later.", Dice.Roll(1, 8), Dice.Roll(2, 4)),
            string.Format("SMOKE CLOUD: 40 ft diameter area becomes lightly obscured.  Attacks in, into, or out of the area are made at disadvantage.  Lasts {0} minutes or until dispersed by wind.",
                Dice.Roll(1,4)),
            "SULFUR CLOUD: Stinking cloud spell",
            string.Format("OBSIDIAN SPIKES: Deals {0} slashing damage to a random character", Dice.Roll(2,4)),
            "NOTHING", "NOTHING", "NOTHING", "NOTHING"
        };
    }
}