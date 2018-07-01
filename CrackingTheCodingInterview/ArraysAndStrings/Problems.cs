using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI.ArraysAndStrings
{
    public class Problems
    {
        public bool HasUniqueCharactersUsingDictionary(string input)
        {
            var chars = new Dictionary<char, bool>();

            for (int i = 0; i < input.Length; i++)
            {
                var character = Char.ToUpper(input[i]);
                if (chars.ContainsKey(character))
                {
                    return false;
                }
                else
                    chars[character] = true;
            }

            return true;

        }

        public bool HasUniqueCharactersUsingFixedArray(string input)
        {
            if (input.Length > 128) return false;
            var characters = new bool[128];

            for (int i = 0; i < input.Length; i++)
            {
                var asciiValue = (int)input[i];
                if (characters[asciiValue])
                    return false;
                else
                    characters[asciiValue] = true;

            }

            return true;
        }
    }
}
