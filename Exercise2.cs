using System;

namespace csharp_exercises
{
    // ** Exercise from the book: the “if” section **

    class Exercise2
    {
        static void Main(string[] args)
        {
            // گرفتن نمره از کاربر
            Console.Write("Enter your class grade: ");
            int a = int.Parse(Console.ReadLine());

            // بررسی نمره و چاپ پیام مناسب
            if (a > 5)
            {
                Console.WriteLine("**You passed**");
            }
            else
            {
                Console.WriteLine("**Sorry, you failed**");
            }

            // برای اینکه کنسول بسته نشه
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
