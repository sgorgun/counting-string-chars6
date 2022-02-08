using System;

namespace CountingStringChars
{
    public static class ForMethods
    {
        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCount(string str)
        {
            // TODO #1. Analyze the implementation of "GetCharCountRecursive" methods, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCount(string str)
        {
            // TODO #2. Analyze the implementation of "GetUpperCharCountRecursive" methods, and implement the method using the "for" loop statement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a number of characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of characters in a string.</returns>
        public static int GetCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetCharCountRecursive(str, 0);
        }

        /// <summary>
        /// Returns a number of upper characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of upper characters in a string.</returns>
        public static int GetUpperCharCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetUpperCharCountRecursive(str, 0);
        }

        private static int GetCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            return GetCharCountRecursive(str, index + 1) + 1;
        }

        private static int GetUpperCharCountRecursive(string str, int index)
        {
            if (index >= str.Length)
            {
                return 0;
            }

            bool isUpper = char.IsUpper(str[index]);
            int currentIncrement = isUpper ? 1 : 0;

            return GetUpperCharCountRecursive(str, index + 1) + currentIncrement;
        }
    }
}
