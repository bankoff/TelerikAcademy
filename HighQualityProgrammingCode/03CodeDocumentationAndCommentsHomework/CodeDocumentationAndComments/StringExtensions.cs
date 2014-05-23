//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="TelerikAcademy">
//     All rights reserved © Telerik Academy 2012-2013
// </copyright>
//-----------------------------------------------------------------------

namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains extension methods for String class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Creates MD5 hash of a string (Message Digest 5)
        /// </summary>
        /// <param name="input">string, whose MD5 hash we want</param>
        /// <returns>128 bit hash of the string</returns>
        /// <seealso cref="http://en.wikipedia.org/wiki/MD5"/>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Checks whether the input string is with boolean value true
        /// </summary>
        /// <param name="input">string to check</param>
        /// <returns>boolean value true if the string can be evaluated to true (if its primary value 
        /// can be found in array with values, that have common meaning of true)</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the input string in <see cref="System.Int16"/>.
        /// </summary>
        /// <param name="input">String to convert.</param>
        /// <returns> If the parse of the input string is successful returns <see cref="System.Int16"/>.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the input string in <see cref="System.Int32"/>.
        /// </summary>
        /// <param name="input">String to convert.</param>
        /// <returns> If the parse of the input string is successful returns <see cref="System.Int32"/>.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the input string in <see cref="System.Int64"/>.
        /// </summary>
        /// <param name="input">String to convert.</param>
        /// <returns> If the parse of the input string is successful returns <see cref="System.Int64"/>.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the input string to <see cref="System.DateTime"/>.
        /// </summary>
        /// <param name="input">String to convert.</param>
        /// <returns>If the parse of the input string is successful returns <see cref="System.DateTime"/>.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// As string is immutable type, this method return new string, which first letter is in uppercase. 
        /// If the input string is null or empty, no changes are made and the input string is returned, as is (original).
        /// </summary>
        /// <param name="input">Original string.</param>
        /// <returns>Copy of the original input string, with its first letter in uppercase.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns substring, that starts from <paramref name="startString"/>, ends at  
        /// <paramref name="endString"/> and starts the search from the index of<paramref name="startFrom"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="startString">The string to start from.</param>
        /// <param name="endString">The string to end to.</param>
        /// <param name="startFrom">The search starting index.</param>
        /// <returns> Returns substring, that is between <paramref name="startString"/>, and  
        /// <paramref name="endString"/> starting the search from the index of<paramref name="startFrom"/>
        /// or empty string, if the wanted substring does not exist.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Transliterates Cyrillic letters to Latin ones.
        /// </summary>
        /// <param name="input">Input string to convert.</param>
        /// <returns>The new string, with converted Cyrillic to latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Transliterates Latin letters to Cyrillic ones according to phonetic keyboard.
        /// </summary>
        /// <param name="input">Input string to convert.</param>
        /// <returns>The new string, with converted Latin to Cyrillic letters according to phonetic keyboard.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts the input string to valid username. Converts Cyrillic to Latin letters 
        /// and removes the characters, which are not letters, digits or dot.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Valid username, containing only Latin letters, digits from zero to nine  and dot.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts the input string to valid filename. Converts Cyrillic to Latin letters, spaces are replaced with hyphens, 
        /// the characters, which are not letters, digits, dot, hyphen, underscore are removed.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>Valid filename, containing only Latin letters, digits from zero to nine, dot, 
        /// hyphen, underscore.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets first characters of a string.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="charsCount">The count of characters to return.</param>
        /// <returns>Returns substring, starting from the 0 index, with length the smaller 
        /// number of the length of the input and specified number of characters in <paramref name="charsCount"/>.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the extension or the file (without the dot) or returns empty string, if the file extension does not exist.
        /// Splits the input string by the dot and returns the last element, which is the file extension.
        /// </summary>
        /// <param name="fileName">String, containing the filename.</param>
        /// <returns>The extension of the file, or empty string if the file extension does not exist.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Returns the content type corresponding to given file extension.
        /// </summary>
        /// <param name="fileExtension">File extension as string.</param>
        /// <returns>The content type as string.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts input string to byte array.
        /// </summary>
        /// <param name="input">This instance.</param>
        /// <returns>Byte array, containing converted input string.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}