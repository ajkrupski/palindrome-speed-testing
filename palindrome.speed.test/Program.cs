using System;
using System.Diagnostics;
using System.Linq;

namespace PalindromeTest

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =
            {
            "civic",
            "deified",
            "deleveled",
            "devoved",
            "dewed",
            "Hannah",
            "kayak",
            "level",
            "madam",
            "racecar",
            "radar",
            "redder",
            "refer",
            "repaper",
            "reviver",
            "rotator",
            "rotor",
            "sagas",
            "solos",
            "sexes",
            "stats",
            "tenet",
            "Jenee",
            "Wes",
            "Sharvari",
            "Andy",
            "Rachel",
            "Edward",
            "Leslie",
            ""
        };

            Stopwatch OrigStopWatch = Stopwatch.StartNew();

            foreach (string value in array)
            {
                IsPalindrome(value);
            }

            OrigStopWatch.Stop();

            Console.WriteLine("Original " + OrigStopWatch.ElapsedMilliseconds);

            Stopwatch V2StopWatch = Stopwatch.StartNew();

            foreach (string value in array)
            {
                IsPalindromeV2(value);
            }

            V2StopWatch.Stop();

            Console.WriteLine("V2 " + V2StopWatch.ElapsedMilliseconds);


            Stopwatch V3StopWatch = Stopwatch.StartNew();
            foreach (string value in array)
            {
                IsPalindromeV3(value);
            }

            V3StopWatch.Stop();

            Console.WriteLine("V3 " + V3StopWatch.ElapsedMilliseconds);

            //foreach (string value in array)
            //{
            //    Console.WriteLine("{0} = {1}, {2}, {3}", value, IsPalindrome(value), IsPalindromeV2(value), IsPalindromeV3(value));
            //}

            Console.ReadLine();
        }

        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public static bool IsPalindromeV2(string value)
        {
            bool ret = true;

            int idx = 0;

            var origString = value.ToList();

            var testString = value.ToList();

            testString.Reverse();

            while (idx < value.Length - 1)

            {
                if (origString[idx] != testString[idx])
                {
                    ret = false;
                    break;
                }
                idx++;
            }

            return ret;
        }

        public static bool IsPalindromeV3(string value)

        {
            var compare = value.ToCharArray();
            Array.Reverse(compare);
            var comparestring = new string(compare);
            return (value == comparestring);

        }
    }
}