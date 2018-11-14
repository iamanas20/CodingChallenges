using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class ArrayManipulator
    {
        public static List<string> MyListOfStrings = new List<string>();

        public static void InsertItemsToArray(string text) => MyListOfStrings.Add(text);

        public static string GetMostRepeatedItemsInArray()
        {
            // go from 0 and next time from 1 and so on
            // from each start save a list of counts and Max count is most repeated number

            List<int> counts = new List<int>();
            int i = 0;
            foreach (string s1 in MyListOfStrings)
            {
                foreach (string s2 in MyListOfStrings)
                {
                    if (s1 == s2)
                    {
                        i++;
                    }
                }
                counts.Add(i);
                i = 0;
            }

            // get the index of the max int from the count
            int indexElementMax = 0;
            List<int> manyindexes = new List<int>();
            int element = counts[0];
            for (int j = 0; j < counts.Count - 2; j++)
            {
                if (element < counts[j + 1])
                {
                    indexElementMax = j + 1;
                    element = counts[j + 1];
                    manyindexes = new List<int>();
                }
                else
                {
                    if (element == counts[j + 1])
                    {
                        manyindexes.Add(indexElementMax);
                        manyindexes.Add(j + 1);
                    }
                }
            }

            string mostRepeatedStrings = String.Empty;

            if (manyindexes.Count != 0)
            {
                mostRepeatedStrings = "Most repeated strings are: ";
                foreach (int index in manyindexes)
                {
                    if (!mostRepeatedStrings.Contains(MyListOfStrings[index]))
                    {
                        mostRepeatedStrings += MyListOfStrings[index] + " + ";
                    }
                }
                mostRepeatedStrings = mostRepeatedStrings.Remove(mostRepeatedStrings.Length - 3, 3);
            }
            else
            {
                mostRepeatedStrings = "Most repeated string is: " + MyListOfStrings[indexElementMax];
            }


            return mostRepeatedStrings;
        }
    }
}
