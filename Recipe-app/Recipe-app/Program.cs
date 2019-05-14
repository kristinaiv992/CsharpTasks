using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_app
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*Exercise
             * ==============================================*
              Create an application for recipes.The app should:
              Ask the user to enter name of recipe
              Ask the user to enter number of ingredients
              Ask the user to enter the name of the ingredients
              After this, the information should be written in a text file with the recipe name
              Bonus
              When the app starts ask the user if they want to read or write a recipe
              When chosen read a recipe ask the user for a name of recipe
              Try and see if you have a recipe by that name in your recipes folder
              If you have a file like that, read it in the console
              If not show error message 
            *=========================================================* */  
            int numberOfIngredients = 0;
                List<string> ingredientsNames = new List<string>();
            string pathFolder = @"C:\Users\kate_\source\repos\Recipe-app\Recipe-app";

            Console.WriteLine("Hello and welcome!");
            Console.WriteLine("Please write the name of your recipe:");
            string recipeName = Console.ReadLine();

            if (!File.Exists(pathFolder + $@"\{recipeName}.txt"))
            {
                File.Create(pathFolder + $@"\{recipeName}.txt").Close();
            }

            string filePath = pathFolder + $@"\{recipeName}.txt";

            Console.WriteLine("Please enter the number of ingredients?");
            bool input = int.TryParse(Console.ReadLine(), out numberOfIngredients);

            if(input && numberOfIngredients > 0)
            {
                int counter = 1;
                for(int i =0; i< numberOfIngredients; i++)
                {
                    Console.WriteLine($"{counter} ingredient:");
                    string name = Console.ReadLine();
                    if(String.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("You did not entered any ingridient");
                    }
                    else
                    {
                        ingredientsNames.Add(name);
                        counter++;
                    }
                }


                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    for (int i = 0; i < ingredientsNames.Count; i++)
                    {
                        sw.WriteLine((i + 1) + "." + ingredientsNames[i]);
                    }
                }
                }
                else {
                    Console.WriteLine("A recipe cannot has 0 or less ingridients");
                }
                Console.WriteLine("Thank You and Goodbye!");
                Console.ReadLine();
            }
            }       
    
}
