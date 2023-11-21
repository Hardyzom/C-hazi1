using System;

namespace Homework{
    public class FizzBuzz{
        private readonly int felsohatar;

        public FizzBuzz(int max){
            felsohatar = max;
        }

        public void Start(){
            for (int i = 1; i <= felsohatar; i++){
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0){
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0){
                    Console.WriteLine("buzz");
                }
                else{
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Program{
        static void Main(string[] args){
            FizzBuzz fb = new FizzBuzz(100);
            fb.Start();
        }
    }
}
