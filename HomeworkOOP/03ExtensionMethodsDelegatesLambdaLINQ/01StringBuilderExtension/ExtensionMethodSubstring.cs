using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01StringBuilderExtension
{
    public static class ExtensionMethodSubstring
    {
        public static StringBuilder SubstringExtension(this StringBuilder input, int index, int length)
        {
            StringBuilder output = new StringBuilder();

            if ((index + length > input.Length) || length <= 0 || index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range argument!");
            }
            for (int i = index; i < index + length; i++)
            {
                output.Append(input[i]);
            }
            return output;
        }
    }
}
