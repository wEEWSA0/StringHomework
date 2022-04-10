using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
        #region Question 18
        static void Question18(string wordOne, string wordTwo)
        {
            Console.Write(isFirstSymbolsEquals(wordOne, wordTwo));
        }
        static bool isFirstSymbolsEquals(string wordOne, string wordTwo)
        {
            return wordOne[0] == wordTwo[0];
        }
        #endregion
        #region Question 63
        static void Question63(string word)
        {
            Console.WriteLine("+: " + CountOfSymbolsInString(word, '+') + ", *: " + CountOfSymbolsInString(word, '*'));
        }
        static int CountOfSymbolsInString(string word, char symbol)
        {
            int count = 0;
            int index = -1;
            while (true)
            {
                index = word.IndexOf(symbol, index+1);
                if (index != -1)
                {
                    count++;
                }
                else
                    break;
            }
            return count;
        }
        #endregion
        #region Question 162
        static void Question162(string word1, string word2, string word3)
        {
            Console.Write("" + CommonSymbols(word1, word2, word3));
        }
        static string CommonSymbols(string word1, string word2, string word3)
        {
            string symbStr = "";
            for (int i = 0; i < word1.Length;)
            {
                if (word2.Contains(word1[i]) && word3.Contains(word1[i]))
                {
                    symbStr += word1[i];
                    word1 = word1.Replace(word1[i].ToString(), "");
                }
                else
                    i++;
            }
            return symbStr;
        }
        #endregion
        /*#region Question 163
        static void Question163(string word1, string word2, string word3)
        {
            string[] mas = { word1, word2, word3 };
            Console.Write("" + UnCommonSymbols(mas));
        }
        static string UnCommonSymbols(string[] word)
        {
            string symbStr = "";
            for (int i = 0; i < word[0].Length;)
            {
                if (word[1].Contains(word[0][i]) && word[2].Contains(word[0][i]))
                {
                    word[0] = word[0].Replace(word[0][i].ToString(), "");
                }
                else
                {
                    symbStr += word[0][i];
                    i++;
                }
            }
            return symbStr;
        }
        #endregion*/
    }
}
