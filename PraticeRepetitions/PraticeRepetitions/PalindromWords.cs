using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeRepetitions
{
    internal class PalindromWords
    {

        public string WordCheck(string word)

        {
            string tershali = "";

            for (int i = word.Length - 1; 0 <= i; i--)
            {
                tershali += word[i];

            }
            if (tershali == word)
            {
                Console.WriteLine("Kelime palindromdur. Kelimenizin ters hali = " + tershali);
            }
            else
            {
                Console.WriteLine("Kelime palindrom değildir. Kelimenizin ters hali =  " + tershali);
            }


            return tershali;

        }

        

    }
}
