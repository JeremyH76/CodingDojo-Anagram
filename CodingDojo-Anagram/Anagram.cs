using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_Anagram
{
    public static class Anagram
    {
        public static List<Tuple<string,string>> Find(string words)
        {
            List<Tuple<string, string>> anagramsFound = new List<Tuple<string, string>>();
            List<string> wordList = words.Split(' ').Where(word => word != "").ToList();
            List<string> wordListOrdered = new List<string>();
            foreach(string word in wordList)
            {
                List<char> charsOfTheWord = word.ToList();
                charsOfTheWord.Sort();
                wordListOrdered.Add(new string(charsOfTheWord.ToArray()));
            }
            for (int i = 0; i < wordListOrdered.Count; i++)
            {
                for (int j = i + 1; j < wordListOrdered.Count; j++)
                {
                    if (wordListOrdered[i] == wordListOrdered[j]) { anagramsFound.Add(new Tuple<string, string>(wordList[i], wordList[j])); }
                }
            }
            return anagramsFound;
        }
    }
}
