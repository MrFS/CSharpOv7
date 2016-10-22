using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv7.Classes
{
    public static class Input
    {
        public static string Baklengs(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Omvendt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            string[] input = s.Split(' ');
            Array.Reverse(input);
            return string.Join(" ", input);
        }

        public static string StorBokstav(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            string[] ord = s.Split(' ');
            string res = "";

            foreach (string item in ord)
            {
                res += StorBokstavPriv(item) + " ";
            }

            return res.Remove(res.Length - 1);
        }

        private static string StorBokstavPriv(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
