using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDD
{
    public class StringUtilities
    {
        public int CountCountOccurences(string stringToCheck, string stringToFind)
        {
            int countResult = -1;

            // Original
            //countResult = stringToCheck.Count(x => Char.ToUpperInvariant(stringToFind[0]) == char.ToUpperInvariant(x));

            //method v2
            //countResult = stringToCheck.Count(x => Char.ToUpperInvariant(stringToFind[0]) == char.ToUpperInvariant(x));

            //method v3
            if (stringToCheck != null)
            {
                countResult = stringToCheck.Count(x => Char.ToUpperInvariant(stringToFind[0]) == char.ToUpperInvariant(x));
            }


            return countResult;


        }
    }
}
