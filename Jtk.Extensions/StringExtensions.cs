namespace Jtk.Extensions
{
    /// <summary>
    /// Extension method for string    
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Whether the string is null
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Whether the string is null</returns>
        public static string NullSafe(this string input)
        {
            return input ?? string.Empty;
        }

        /// <summary>
        /// Whether the string is null or empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Whether the string is null or empty</returns>
        public static bool IsNullOrEmpty(this string input)
        {
            return string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Whether the string is not null or empty
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Whether the string is not null or empty</returns>
        public static bool IsNotNullOrEmpty(this string input)
        {
            return !string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Whether the string is null or just white space
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Whether the string is null or just white space</returns>
        public static bool IsNullOrWhiteSpace(this string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Whether the string is not null or just white space
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Whether the string is not null or just white space</returns>
        public static bool IsNotNullOrWhiteSpace(this string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Parse string into a nullable integer type without causing exception
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Nullable integer</returns>
        public static int? TryParse(this string input)
        {
            int output;
            if (int.TryParse(input, out output))
            {
                return output;
            }

            return null;
        }
    }
}
