using System;
using System.Collections.Generic;
namespace exercise_135
{
    class UserInterface
    {
        private JokeManager jokeManager; //An instance of the JokeManager object class

        public UserInterface(JokeManager jokeManager) //Constructor
        {
            this.jokeManager = jokeManager;
        }

        public void Start() //Starts the functions in the program
        {
            while (true) //Starts the program loop
            {
                Console.WriteLine("Commands:" + "\n"
                 + "1 - add a joke" + "\n"
                  + "2 - draw a joke" + "\n"      //Prints out the possible commands for the user to see
                   + "3 - list jokes" + "\n"
                    + "X - stop");


                string input = Console.ReadLine(); //User input

                if (input == "X" || input == "x")
                {
                    break;
                }

                if (input == "1")
                {
                    Console.WriteLine("Write the joke to be added:");
                    jokeManager.AddJoke(Console.ReadLine()); //Adds whatever the user inputs into the list of jokes in JokeManager
                }

                else if (input == "2")
                {
                    Console.WriteLine("Drawing a joke.");
                    Console.WriteLine(jokeManager.DrawJoke()); //Draws a random joke from the list
                }
                else if (input == "3")
                {
                    Console.WriteLine("Printing jokes."); //Prints out all the jokes in the list
                    jokeManager.PrintJokes();
                }
            }
        }

    }
}