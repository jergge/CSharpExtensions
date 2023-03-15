public static partial class Extensions
{
    /// <summary>
    /// Cuts a string down to length
    /// </summary>
    /// <param name="s"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    public static string Truncate(this string s, int length)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }
        
        return s.Length <= length ? s : s.Substring(0, length);
    }
}