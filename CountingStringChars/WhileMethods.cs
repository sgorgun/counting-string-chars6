using System;

namespace CountingStringChars
{
    public static class WhileMethods
    {
        /// <summary>
        /// Returns a number of white space characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of white space characters in a string.</returns>
        public static int GetSpaceCount(string str)
        {
            // TODO #3. Analyze the implementation of "GetSpaceCountRecursive" method, and implement the method using the "while" loop statement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a number of punctuation marks in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of punctuation marks in a string.</returns>
        public static int GetPunctuationCount(string str)
        {
            // TODO #4. Analyze the implementation of "GetPunctuationCount" method, and implement the method using the "while" loop statement.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a number of white space characters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of white space characters in a string.</returns>
        public static int GetSpaceCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = GetSpaceCountRecursive(str[1..]) + (char.IsWhiteSpace(str[0]) ? 1 : 0);

            return result;
        }

        /// <summary>
        /// Returns a number of punctuation marks in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of punctuation marks in a string.</returns>
        public static int GetPunctuationCountRecursive(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            bool isPunctuation = char.IsPunctuation(str[0]);
            int currentIncrement = isPunctuation ? 1 : 0;
            int result = GetPunctuationCountRecursive(str[1..]) + currentIncrement;

            return result;
        }
    }
}
