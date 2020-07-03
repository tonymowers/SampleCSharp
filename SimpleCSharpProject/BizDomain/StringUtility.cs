namespace SimpleCSharpProject.BizDomain
{
    public static class StringUtility
    {
        public static string FirstLetterOfSentenceToUpper(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            bool isStart = true;
            var result = "";
            foreach (var c in s)
            {
                if (" ".Contains(c))
                {
                    result += c;
                    continue;
                }

                if (isStart)
                {
                    isStart = false;
                    result += char.ToUpper(c);
                    continue;
                }

                if (".?".Contains(c))
                {
                    isStart = true;
                    result += c;
                    continue;
                }
                result += c;
            }

            return result;
        }
    }
}