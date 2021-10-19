using System;
using System.Collections.Generic;

namespace GCDevBuildMovieListLab
{
    class Program
    //How is a class different from an object? How are public methods different from private?
    //classes can be thought of more as a blue print or insturctions of how to create an object. We must first create a class 
    // in order to create an object An object is a product or instance of that class. Public methods are accessible from other classes
    //while priavte methods are only accessible from  that related class and realted fields.
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
