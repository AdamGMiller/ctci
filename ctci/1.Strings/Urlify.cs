namespace ctci._1.Strings
{
    public class Urlify
    {
        public string ToUrl(string url, int stringLength)
        {
            return url.TrimEnd().Replace(" ", "%20");
        }
    }
}
