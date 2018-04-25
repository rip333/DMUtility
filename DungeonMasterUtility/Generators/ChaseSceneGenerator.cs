using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonMasterUtility.Generators
{
    public class ChaseSceneGenerator
    {
        private Random r = new Random();

        public string generateCharacterAction()
        {
            return characterActions.ElementAt(r.Next(characterActions.Count));
        }

        List<String> characterActions = new List<string>
        {
            "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing",
            "Low Branches: Dex Saving Throw 13 to avoid being hit by branches or take 1d4 slashing damage.  Less than 3 get knocked off their mount.",
            "Low Branches: Dex Saving Throw 13 to avoid being hit by branches or take 1d4 slashing damage.  Less than 3 get knocked off their mount.",
            "Low Branches: Dex Saving Throw 13 to avoid being hit by branches or take 1d4 slashing damage.  Less than 3 get knocked off their mount.",
            "Low Branches: Dex Saving Throw 13 to avoid being hit by branches or take 1d4 slashing damage.  Less than 3 get knocked off their mount.",
            "Fallen Tree: Animal Handling Check DC 10 to jump, or lose 20 feet of speed",
            "Fallen Tree: Animal Handling Check DC 10 to jump, or lose 20 feet of speed",
            "Shortcut: Perception check dc 16 - you find a shortcut and gain 20 ft of speed",
            "Bee hive: Dex Saving Throw 10 or disturb a swarm of bees.  They will attack you and the two nearest characters for 1d4 damage.",
            "Difficult Terrain: Dex Saving Throw 10 to avoid slipping off.  Acrobatics check 10 to regain hold.",
            "Difficult Terrain: Dex Saving Throw 10 to avoid slipping off.  Acrobatics check 10 to regain hold."
        };
    }
}