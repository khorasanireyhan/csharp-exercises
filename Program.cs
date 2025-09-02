using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises

   //Extra exercises for7 C# beyond the textbook.
{
    class Program
    {
        /*تمرین ۱
        توضیح: گرفتن ورودی سن کاربر و نمایش آن
        */
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("your age is" + age);

        }
    }
}
