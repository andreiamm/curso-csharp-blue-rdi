using System;

namespace exercicio05
{
    internal class Strings
    {
        public string Abbreviate(string s)
        {
            string[] substr = s.Split(' ');
            string abbr = "";

            foreach (string str in substr)
            {
                if (str.Length > 2)
                {
                    abbr += str[0] + ". ";
                }
                else
                {
                    abbr += str + " ";
                }
            }
            return abbr;
        }

        public string RevertString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string str = new string(arr);
            return str.ToLower();
        }

        public string CountVowelsAndConsonants(string s)
        {
            s = s.ToLower();
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
  
            }
           return $"Seu nome possui {vowels} vogais e {consonants} consoantes.";
        }
    }
}
