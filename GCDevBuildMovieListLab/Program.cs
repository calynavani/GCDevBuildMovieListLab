using System;
using System.Collections.Generic;

namespace GCDevBuildMovieListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Declare a variable that can refernce a movie object
            Movie m = new Movie();
           
            Console.WriteLine("Welcome to My Movie List Application"); ;

            bool goOn = true;
            while (goOn == true)
            {



                Console.WriteLine();
                Console.WriteLine("I have 10 movies in my list.");
                Console.WriteLine("The categories are: ");

                m.DisplayCategories();

                string userCatSelection = m.GetUserInput();

                if (userCatSelection == "animation")
                {
                    m.DisplayTitlesAnimated();

                }
                else if (userCatSelection == "drama")
                {
                    m.DisplayTitlesDrama();
                }
                else if (userCatSelection == "horror")
                {
                    m.DisplayTitlesHorror();
                }
                else if (userCatSelection == "sci-fi")
                {
                    m.DisplayTitlesSciFi();
                }


               if( m.Continue() == false)
                {
                    break;

                }
                
            }

                
            
        

        }
    }
}
