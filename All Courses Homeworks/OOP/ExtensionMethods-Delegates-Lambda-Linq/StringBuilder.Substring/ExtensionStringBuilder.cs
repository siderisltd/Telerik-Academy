namespace StringBuilderSubstring
{
    using System.Text;

    public static class ExtensionStringBuilder
    {
        public static StringBuilder SubString(this StringBuilder some, int index, int length)
        {
            if (some.Length < index || some.Length < index + length)
            {
                throw new System.IndexOutOfRangeException("You are out of range");
            }
            StringBuilder result = new StringBuilder();
            result.Append(some.ToString().Substring(index, length));
            return result;
        }
    }
}
