using System;
class Program{
    static void Main(){
        int number;
        do{
            Console.Write("Enter a value bigger than 0: ");
            number = Convert.ToInt32(Console.ReadLine());
            if(number <= 0){
                Console.WriteLine("You must Input a value bigger than 0!!!");
            }
            
                    }
                    while(number >= 0){
                        Console.WriteLine("Yesss, That's Right value.")
                    }
    }
}