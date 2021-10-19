using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildMovieListLab
{
    class Movie
    {
        //fields
        private string Title;

        private string Category;

        ////Constructor


        //Movie(string Title, string Category)
        //{

        //    this.Title = Title;

        //    this.Category = Category;

        //}
        ////Methods




        public string GetUserInput()
        {
            Console.WriteLine();
            Console.Write("What category are you interested in? "); 
            string userInput = Console.ReadLine().ToLower();
            while(userInput != "animation" && userInput != "drama" && userInput != "horror" && userInput != "scifi")
            {
                Console.WriteLine("That was an invalid response");
                Console.WriteLine("Please try again, select a category from the list.");
                Console.Write("What category are you interested in? ");
                userInput = Console.ReadLine().ToLower();
            }
            return userInput;
            
        }
        public void DisplayTitlesAnimated()
        {
            List<string> animated = new List<string>();
            animated.Add("The Lion King");
            animated.Add("Shark Tale");
            

            foreach(string title in animated)
            {
                Console.WriteLine(title);
                
            }

            
            
        }
        public void DisplayTitlesDrama()
        {
            List<string> drama = new List<string>();
            drama.Add("Kill Bill");
            drama.Add("The Longest Yard");
            

            foreach (string title in drama)
            {
                Console.WriteLine(title);
                
            }



        }
        public void DisplayTitlesHorror()
        {
            List<string> horror = new List<string>();
            
            horror.Add("The Texas Chainsaw Massacre");
            horror.Add("Saw");
           

            foreach (string title in horror)
            {
                Console.WriteLine(title);
               
            }



        }
        public void DisplayTitlesSciFi()
        {
            List<string> SciFi = new List<string>();

           
            SciFi.Add("Undrworld");
            SciFi.Add("E.T.");

            foreach (string title in SciFi)
            {
                Console.WriteLine(title);
               
            }



        }



        public void DisplayCategories()
        {
            List<string> Category = new List<string>();
            Category.Add("Animation");
            Category.Add("Drama");
            Category.Add("Horror");
            Category.Add("Sci-Fi");
            Console.WriteLine();

            foreach (string category in Category)
            {
                Console.WriteLine(category);
            }


        }
        public bool Continue()
        {
            Console.Write("Would you like to continue? y/n: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;



            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand");
                Console.WriteLine("Let's try again.");


                return Continue();
            }

        }












    }
}
