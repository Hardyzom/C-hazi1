using System;

namespace Homework{
    class Ezernelkisebb{
        private static int Egeszosszege(int max){
            int osszeg = 0;

            for (int i = 1; i < max; i++){
                if (i % 3 == 0 || i % 5 == 0){
                    osszeg += i;
                }
            }

            return osszeg;
        }

        public static void Main(string[] args){
            int max = 1000;
            int eredmeny = Egeszosszege(max);

            Console.WriteLine($"{eredmeny}");
        }
    }
}
