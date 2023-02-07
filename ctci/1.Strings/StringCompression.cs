using System.Text;

namespace ctci._1.Strings
{
    public class StringCompression
    {
        public string CompressString(string input)
        {
            var inputCharacters = input.ToCharArray();
            var outputString = new StringBuilder();
            const char nullCharacter = '\0';
            char currentCharacter = nullCharacter;
            var characterCount = 0;
            for (int i = 0; i < inputCharacters.Length; i++)
            {
                var character = inputCharacters[i];
                if (currentCharacter == character)
                {
                    characterCount++;
                }
                else
                {
                    outputString.Append(CharacterOutput());
                    currentCharacter = character;
                    characterCount = 1;
                }

                if (i == inputCharacters.Length - 1)
                {
                    outputString.Append(CharacterOutput());
                }
            }

            return outputString.ToString();

            string CharacterOutput()
            {
                if(currentCharacter == nullCharacter)
                {
                    return string.Empty;
                }
                return characterCount == 1 ? currentCharacter.ToString() : $"{currentCharacter}{characterCount}";
            }
        }
    }
}
