using System;

namespace Homework{
    class Sztringek1{
        private static string Donuts(int n){
            return n >= 10 ? "Fánkok száma: sok" : $"Fánkok száma: {n}";
        }

        private static string BothEnds(string s){
            return s.Length <= 2 ? "" : $"{s.Substring(0, 2)}{s.Substring(s.Length - 2)}";
        }

        private static string FixStart(string s){
            char firstChar = s[0];
            string replacedString = s.Substring(1).Replace(firstChar, '*');
            return $"{firstChar}{replacedString}";
        }

        private static string MixUp(string a, string b){
            string mixedString = $"{b.Substring(0, 2)}{a.Substring(2)}";
            string mixedString2 = $"{a.Substring(0, 2)}{b.Substring(2)}";
            return $"{mixedString} {mixedString2}";
        }

        private static void Test(string got, string expected){
            var prefix = (got == expected ? " OK " : "  X ");
            Console.WriteLine($"{prefix} got: {got}; expected: {expected}");
        }

        public static void Main(string[] args){
            Test(Donuts(4), "Fánkok száma: 4");
            Test(Donuts(9), "Fánkok száma: 9");
            Test(Donuts(10), "Fánkok száma: sok");
            Test(Donuts(99), "Fánkok száma: sok");
            Console.WriteLine("#");
            Test(BothEnds("spring"), "spng");
            Test(BothEnds("Hello"), "Helo");
            Test(BothEnds("a"), "");
            Test(BothEnds("xyz"), "xyyz");
            Console.WriteLine("#");
            Test(FixStart("babble"), "ba**le");
            Test(FixStart("aardvark"), "a*rdv*rk");
            Test(FixStart("google"), "goo*le");
            Test(FixStart("donut"), "donut");
            Console.WriteLine("#");
            Test(MixUp("mix", "pod"), "pox mid");
            Test(MixUp("dog", "dinner"), "dig donner");
            Test(MixUp("gnash", "sport"), "spash gnort");
            Test(MixUp("pezzy", "firm"), "fizzy perm");
        }
    }
}
