using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Word_Occurrence_Calculator
{
    public class WordCalculator
    {

        public static List<WordOccurrence> CalculateOccurrences(List<string> sList)
        {
            // check if sList is null throw arguement exception. 
            if(sList == null)
            {
                throw new ArgumentException("Invalid input.");
            }

            // create a dictionary to easily keep track of the count of each word ocurrence in the list.
            Dictionary<string, int> wordDict = new Dictionary<string, int>();

            // loop through the list add each word to the dictionary.
            foreach(string word in sList)
            {
                if(wordDict.ContainsKey(word))
                {
                    wordDict[word] += 1;
                }
                else
                {
                    wordDict.Add(word, 1);
                }
            }

            // create WordOccurrence objects out of dictionary.
            List<WordOccurrence> words = CreateList(wordDict);

            // return a list of WordOccurence objects.
            return words;
        }

        private static List<WordOccurrence> CreateList(Dictionary<string, int> wordDict)
        {
            // create default list of WordOccurence objects.
            List<WordOccurrence> returnList = new List<WordOccurrence>();

            // loop through the dictionary and create a new WordOccurence object with the key and value.
            foreach(KeyValuePair<string, int> entry in wordDict)
            {
                WordOccurrence newWord = new WordOccurrence
                {
                    Word = entry.Key
        
                };

                newWord.Count = entry.Value;

                // add object to the default list.
                returnList.Add(newWord);
            }

            // return the list.
            return returnList;
        }
    }
}
