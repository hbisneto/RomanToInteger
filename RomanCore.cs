using System.Collections.Generic;

namespace RomanToInteger
{
    internal class RomanCore
    {
        public int RomanToInteger(string RomanString)
        {
            int Soma = 0;
            Dictionary<char, int> RomanDictionary = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < RomanString.Length; i++)
            {
                char RomanChar = RomanString[i];
                RomanDictionary.TryGetValue(RomanChar, out int Numero);
                if (i + 1 < RomanString.Length && RomanDictionary[RomanString[i + 1]] > RomanDictionary[RomanChar])
                {
                    Soma -= Numero;
                }
                else
                {
                    Soma += Numero;
                }
            }
            return Soma;
        }
    }
}