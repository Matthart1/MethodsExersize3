using System;

namespace MethodExersize3
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualOrNot();
            EvenOrOdd();
            PossitiveOrNegative();
            CanYouVote();
            
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 3; i >= -999; i -= 3) //Goes from 3 down to negative 999.
            {
                Console.WriteLine(i);
            }

            static void EqualOrNot()
            {
                Console.WriteLine("Give me two number.");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    Console.WriteLine("The are equal.");
                }
                else
                {
                    Console.WriteLine("They are not equal");
                }
            }


            static void EvenOrOdd()
            {
                Console.WriteLine("Give me a number.");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }


            static void PossitiveOrNegative()
            {
                Console.WriteLine("Give me a number.");
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    Console.WriteLine("The number is possitive!!");
                }
                else
                {
                    Console.WriteLine("The number is negative.");
                }
            }

            
            static void CanYouVote()
            {
                
                Console.WriteLine("How old are you?");
                var age = int.Parse(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("You are ready to vote my friend!!!");
                }
                else
                {
                    Console.WriteLine("Sorry bud, you got a few more years..");
                }
                Console.ReadLine();
            }
            
        }
    }
}
