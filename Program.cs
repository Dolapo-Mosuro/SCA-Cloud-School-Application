using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
          int numberToGuess = 7;
          int userGuess = 0;
          int chances = 0;
          string levels = "";
          string wrongInputOutput = "";


          Console.Write("Welcome, Select from 1- Easy, 2- Medium and 3- Hard: " );
          int numberChosen = int.Parse(Console.ReadLine());

          if(numberChosen == 1)
          {
            levels = "Easy";
          }
          else if (numberChosen == 2)
          {
            levels = "Medium";            
          }
          else if (numberChosen == 3)
          {
            levels = "Hard";            
          }

        else
        {
         wrongInputOutput = "Wrong, start again. Thank you.";
        }
          
          if (levels == "Easy")
         
        try
        {
          userGuess != numberToGuess)
          {      
                chances = 3;
                 Console.WriteLine(playGame(1,10, chances, numberToGuess, userGuess));
                {
                  catch(FormatException ex)
                } 
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("start again. ");

                int.TryParse(Console.ReadLine(), out userGuess);

                 if (userGuess > numberToGuess)
                 {
                     Console.WriteLine("{0} is too high!", userGuess);
                 }

                 else if (userGuess < numberToGuess)
                 {
                   Console.WriteLine("{0} is too low!", userGuess);
                 }
                 else
                 {
                     Console.WriteLine("{0} is right! Congratulations.", userGuess);
                 }

          }


        }

    }     
}