using System.Text;

namespace ctci._1.Strings
{
    public class StringRotation
    {
        public bool IsRotation(string originalString, string possibleRotation)
        {
            if (originalString.Length != possibleRotation.Length)
            {
                return false;
            }

            var doubledPossibleRotation = possibleRotation + possibleRotation;
            return doubledPossibleRotation.Contains(originalString);
        }
    }
}
