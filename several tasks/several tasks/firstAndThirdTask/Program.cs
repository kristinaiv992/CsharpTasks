using firstAndThirdTask.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cat
            Cat Tom = new Cat();
            Tom.Name = "Tommy";
            Tom.Age = 190;
            Tom.Color = "yellow green";
            Tom.IsLazy = true;
            Tom.Print();
            Tom.Meaow();
            //Dog
            //Dog Shillo = new Dog();
            //Shillo.Age = 390;
            //Shillo.Color = "pink";
            //Shillo.Name = "Shillo";
            //Shillo.Race = "German Shepard";
            //Shillo.Print();
            //Shillo.Bark();
            ////Bird
            //Bird koki = new Bird();
            //koki.isWild = true;
            //koki.Name = "Koki";
            //koki.Age = 17;
            //koki.Color = "green";
            //koki.FlySouth();
            //koki.Print();
            //Console.ReadLine();

            //task3 generic 
            var dog1 = new Dog() { Name = "Jecky", Age = 7, Color = "Black", Race = "Doberman" };
            var cat1 = new Cat() { Name = "Mac", Age = 43, Color = "Brown", IsLazy = true };
            var bird1 = new Bird() { Name = "Coco", Age = 205, Color = "Yellow", isWild = true };

            var ListAni = new List<Animals>() { dog1, cat1, bird1 };
            Generic.PrintAnimals(ListAni);
           


        }
    }
    
}
