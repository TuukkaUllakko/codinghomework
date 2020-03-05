using System;
using System.Collections.Generic;
namespace exercise_135
{
    class JokeManager
    {
        private List<string> jokes; //List to store the jokes in

        public JokeManager() //Constructor (Blueprint)
        {
            this.jokes = new List<string>(); //Creates a copy of the jokes-list that can be called upon with this.jokes
        }

        public void AddJoke(string joke) //Method for adding jokes to the list jokes.
        {
            this.jokes.Add(joke); //Adds the joke given as a parameter to the list jokes.
        }

        public string DrawJoke() //Method that returns a random joke from the list
        {
            if (this.jokes.Count == 0) //If there are no jokes
            {
                return "Jokes are in short supply"; //Return this
            }
            Random draw = new Random();
            int index = draw.Next(0, this.jokes.Count); //If there are jokes
            return this.jokes[index];     //Return this
        }

        public void PrintJokes() //Method for printing all the given jokes
        {
            foreach (string joke in this.jokes) //For each joke in the list jokes
            {
                Console.WriteLine(joke); //Print out the joke
            }
        }
    }
}