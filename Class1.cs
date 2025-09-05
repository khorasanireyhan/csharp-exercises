using System;

namespace csharp_exercises
{
    // C# in easy way (book)_
    class Exercise2
    {
        // **First exercise of the book: the “if” section**

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number = int.Parse(Console.ReadLine());  // گرفتن ورودی از کاربر و تبدیل به عدد

            if (number > 10)
            {
                Console.WriteLine("Hello world");
            }
            if (number < 10)
            {
                Console.WriteLine("Goodbye world");
            }
            if (number == 10)
            {
                Console.WriteLine("Your number is 10");
            }

        }
    }
}


