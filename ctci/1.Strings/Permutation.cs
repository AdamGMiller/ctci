namespace ctci._1.Strings
{
    public class Permutation
    {
        public bool CheckInclusion(string permutationString, string containingString)
        {
            var container = containingString.ToCharArray();
            var containerLength = containingString.Length;
            var permutationLength = permutationString.Length;
            var permutationDictionary = this.CreateDictionaryOfCharactersAndCounts(permutationString);
            var permutationsFoundCounts = new Dictionary<char, int>();
            var permutationsFound = 0;

            for (var index = 0; index < containerLength; index++)
            {
                var character = container[index];
                if (permutationDictionary.ContainsKey(character))
                {
                    IncreaseFoundCharactersByOne(character);
                }

                if (index > permutationLength - 1)
                {
                    ReduceFoundCharactersIfPresent(container[index - permutationLength]);
                }

                if (index >= permutationLength - 1)
                {
                    if (permutationDictionary.ContainsKey(character))
                    {
                        if (PermutationFound())
                        {
                            return true;
                        }
                    }
                }
            }

            return false;

            bool PermutationFound()
            {
                if (permutationsFound != permutationLength)
                {
                    return false;
                }

                if (AllPermutationsFoundCountsAreEqual())
                {
                    return true;
                }

                return false;
            }

            bool AllPermutationsFoundCountsAreEqual()
            {
                foreach (var character in permutationDictionary.Keys)
                {
                    if (!permutationsFoundCounts.ContainsKey(character) || permutationsFoundCounts[character] != permutationDictionary[character])
                    {
                        return false;
                    }
                }
                return true;
            }

            void IncreaseFoundCharactersByOne(char character)
            {
                permutationsFound++;
                if (permutationsFoundCounts.ContainsKey(character))
                {
                    permutationsFoundCounts[character]++;
                }
                else
                {
                    permutationsFoundCounts.Add(character, 1);
                }
            }

            void ReduceFoundCharactersIfPresent(char character)
            {
                if (permutationsFoundCounts.ContainsKey(character))
                {
                    permutationsFoundCounts[character]--;
                    permutationsFound--;
                    if (permutationsFoundCounts[character] == 0)
                    {
                        permutationsFoundCounts.Remove(character);
                    }
                }
            }
        }

        private Dictionary<char, int> CreateDictionaryOfCharactersAndCounts(string s)
        {
            var characters = s.ToCharArray();
            var dictionary = new Dictionary<char, int>();

            foreach (var character in characters)
            {
                if (dictionary.ContainsKey(character))
                {
                    dictionary[character] = dictionary[character] + 1;
                }
                else
                {
                    dictionary.Add(character, 1);
                }
            }

            return dictionary;
        }
    }
}