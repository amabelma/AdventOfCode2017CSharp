using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day7
{
    public class TowerSorter
    {
        public string GetBaseValue(List<string> input)
        {
            string baseValue = string.Empty;
            var unSortedValues = input;
            List<string> towerLevelInScope = new List<string>();
            List<string> recursiveTowerLevel = new List<string>();

            // The highest level contains the values without an arrow in them
            Regex rgx_noArrow = new Regex(@"^((?!->).)*$");
            foreach(string val in unSortedValues)
            {
                if(rgx_noArrow.IsMatch(val))
                {
                    towerLevelInScope.Add(val);
                    unSortedValues.Remove(val);
                }
            }

            List<string> valuesOneTierUp = new List<string>();
            Regex rgx_numberInParens = new Regex(@"\(.*\)");
            Regex rgx_afterTheArrow = new Regex(@"(?<=(\-\>)).*");
            while(notDone)
            {
                // The next level contains the values that reference the previous values
                // Get the individual references from the towerLevelInScope
                foreach(string val in towerLevelInScope)
                {
                    var blub = val.Split("->")
                }
                foreach(string val in unSortedValues)
                {
                    valuesOneTierUp
                    // foreach string in towerLevelInScope.... split by "," after the -> ... put in one big list
                    // foreach string val in unSortedValues....... split by "," after the ->
                    // if(towerLevelInScope.Contains(val))

                }
            }

            return baseValue;
        }

        
    }
}