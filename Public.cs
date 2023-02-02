using System;
namespace Exercise1and2
{
	public class Public
	{
        public static int Add(int num1, int num2)
        {
            // exercise 2 
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num3, int num4)
        {
             var answer = num3 * num4;
             return answer;

        }
		public Public()
            {
                var amountOfDogs = Add(2, 6);
                var amountOfCats = Multiply(1, 1);

                // exercise 1 
                Console.WriteLine("What is your name?");// output 
                var name = Console.ReadLine(); // input

                Console.WriteLine($"Hi,{name},What is your favorite color?");// output 
                var color = Console.ReadLine(); // input

                Console.WriteLine($"{color}, is great! Whats your favorite animal?");// output 
                var animal = Console.ReadLine(); // input

                Console.WriteLine($"{animal} is very cool! What is your favorite band?");// output 
                var band = Console.ReadLine(); // input
            }

        }
	}


