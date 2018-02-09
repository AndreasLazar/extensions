using System;
using System.Text.RegularExpressions;

namespace Lazar.Extensions
{
    public static class StringExt
    {
        public static string SplitCamelCase(this string str)
            => string.Join(" ", Regex.Split(str, @"(?<!^)(?=[A-Z])"));

        public static string RemoveLastXChars(this string str, int number)
            => str.Length >= number ? 
                str.Substring(0, str.Length - number) :
                string.Empty;

        public static string RemoveLastChar(this string str)
            => str.RemoveLastXChars(1);

        public static string RemoveFirstXChars(this string str, int number)
            => str.Length >= number ? 
                str.Substring(number) : 
                string.Empty;

        public static string RemoveFirstChar(this string str)
            => str.RemoveFirstXChars(1);

        public static T ToEnum<T>(this string str)
            => string.IsNullOrEmpty(str) ? 
                default(T) : 
                (T)Enum.Parse(typeof(T), str);
    }
}
