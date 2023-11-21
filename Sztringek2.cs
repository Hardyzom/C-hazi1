using System;

namespace Homework{
    class Sztringek2{
        private static string Verbing(string s){
            if (s.Length < 3) return s;

            if (s.EndsWith("ing"))
                return $"{s}ly";
            else
                return $"{s}ing";
        }

        private static string NotBad(string s){
            int notIndex = s.IndexOf("not");
            int badIndex = s.IndexOf("bad");

            if (notIndex != -1 && badIndex != -1 && notIndex < badIndex){
                return $"{s.Substring(0, notIndex)}good{s.Substring(badIndex + 3)}";
            }

            return s;
        }

        private static string FrontBack(string a, string b){
            int aMid = (a.Length + 1) / 2;
            int bMid = (b.Length + 1) / 2;

            return $"{a.Substring(0, aMid)}{b.Substring(0, bMid)}{a.Substring(aMid)}{b.Substring(bMid)}";
        }

        private static void Test(string got, string expected){
            var prefix = (got == expected ? " OK " : "  X ");
            Console.WriteLine($"{prefix} got: {got}; expected: {expected}");
        }

        public static void Main(string[] args){
            Console.WriteLine("verbing");
            Test(Verbing("hail"), "hailing");
            Test(Verbing("swiming"), "swimingly");
            Test(Verbing("do"), "do");

            Console.WriteLine();
            Console.WriteLine("not_bad");
            Test(NotBad("This movie is not so bad"), "This movie is good");
            Test(NotBad("This dinner is not that bad!"), "This dinner is good!");
            Test(NotBad("This tea is not hot"), "This tea is not hot");
            Test(NotBad("It's bad yet not"), "It's bad yet not");

            Console.WriteLine();
            Console.WriteLine("front_back");
            Test(FrontBack("abcd", "xy"), "abxcdy");
            Test(FrontBack("abcde", "xyz"), "abcxydez");
            Test(FrontBack("Kitten", "Donut"), "KitDontenut");
        }
    }
}
