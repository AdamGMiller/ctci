namespace ctci._1.Strings
{
    public class OneAway
    {
        public bool IsOneAway(string initial, string modified)
        {
            if (initial == modified)
            {
                return true;
            }

            if (LengthDifferenceIsGreaterThanOne())
            {
                return false;
            }

            if (ModifiedStringHasCharacterAddedToEnd())
            {
                return true;
            }

            for (int i = 0; i < initial.Length; i++)
            {

                // test if character at position i was removed
                var initialMinusCharacter = GetStringWithCharacterAtIndexRemoved(initial, i);

                if (DoesModifiedStringHaveCharacterRemovedAtIndex(initialMinusCharacter, modified))
                {
                    return true;
                }

                // test if a character was replaced at position i
                var initialMinusCharacterInModified = GetStringWithCharacterAtIndexRemoved(modified, i);

                if (DoesModifiedStringHaveCharacterReplacedOrAddedAtIndex(initialMinusCharacterInModified, initialMinusCharacter, modified))
                {
                    return true;
                }
            }
            return false;

            bool LengthDifferenceIsGreaterThanOne()
            {
                return Math.Abs(initial.Length - modified.Length) > 1;
            }

            bool ModifiedStringHasCharacterAddedToEnd()
            {
                if (initial.Length == modified.Length - 1)
                {
                    if (initial == modified.Substring(0, initial.Length))
                    {
                        return true;
                    }
                }
                return false;
            }

            bool DoesModifiedStringHaveCharacterReplacedOrAddedAtIndex(string initialMinusCharacterInModified, string initialMinusCharacter, string modified)
            {
                return initialMinusCharacterInModified == initialMinusCharacter ||
                    initialMinusCharacterInModified == initial;
            }

            bool DoesModifiedStringHaveCharacterRemovedAtIndex(string initialMinusCharacter, string modified)
            {
                return initialMinusCharacter == modified;
            }

            string GetStringWithCharacterAtIndexRemoved(string input, int index)
            {
                return index == 0 ? input.Substring(1, input.Length - 1) :
                    index == input.Length ? input.Substring(0, input.Length - 1) :
                    input.Substring(0, index) + input.Substring(index + 1, input.Length - index - 1);
            }
        }
    }
}
