using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Choose your Challenge: Enter (0) for Easy , or (1) for Hard.")
        Random rnd = new Random();
        int choice = Convert.ToInt32(Console.ReadLine());
        int secretNumber = 0;
        if (choice == 0){
            // easy level
            int secretNumber = rnd.Next(1, 51); //creates a nunber between 1 and 100


        }
        else if (choice == 1){
            // hard level
            int secretNumber = rnd.Next(1, 101); //creates a number between 1 and 500
        }
        else{
            Console.WriteLine(@"Invalid choice.
            Please enter 0 or 1 .").
        }
        int guess;
        int attempts = 0;
        while (true)
        {
         Console.WriteLine("Enter your guess:");
         guess = Convert.ToInt32(Console.ReadLine());
         attempts++;

         if (guess < secretNumber){
            Console.WriteLine("Too low! Try again.")
         }   
         else if ( guess > secretNumber){
            Console.WriteLine("Too high! Try again.")
         }
         else{
            Console.WriteLine("Congratulations! You guessed the number in {0} attemps.", attemps);
         }
        }
        Console.ReadKey;
    }
}