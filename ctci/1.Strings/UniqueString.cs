namespace ctci._1.Strings
{
    public class UniqueString
    {
        public bool IsUnique(string input)
        {
            var hash = new HashSet<char>();
            var inputCharacters = input.ToCharArray();

            foreach (var character in inputCharacters)
            {
                if (!hash.Add(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}