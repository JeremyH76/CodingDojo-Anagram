using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_Anagram
{
    public static class Anagram
    {
        public static List<Tuple<string,string>> Find(string v)
        {
            List<Tuple<string, string>> ret = new List<Tuple<string, string>>();
            List<string> words = v.Split(' ').Where(x => x != "").ToList();
            List<string> list = new List<string>();
            foreach(string word in words)
            {
                List<char> toAdd = word.ToList();
                toAdd.Sort();
                list.Add(new string(toAdd.ToArray()));
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j]) { ret.Add(new Tuple<string, string>(words[i], words[j])); }
                }
            }
            return ret;
        }
    }
}
