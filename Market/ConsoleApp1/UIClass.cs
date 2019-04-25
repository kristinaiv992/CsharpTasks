using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UIClass
    {
        public static void WellcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the shop");
            Console.WriteLine("press any key to continue");

            while (true)
            {

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Do you want to see all the items we offer to you? press Y?N");
                Console.ResetColor();
                string choice = Console.ReadLine().ToLower();
                if (choice != "y" && choice != "n") continue;
                if (choice == "n" || choice == "no")
                {
                    Console.WriteLine("Thank you for visiting us");
                    break;
                }
                foreach (var item in Db.Foods)
                {
                    item.PrintAll();
                }
                break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------");

                double temp=0;
            while (true)
            {
                Console.WriteLine("Would you buy something from the shop? Press Y|N");
                var answer = Console.ReadLine().ToLower();
                if (answer != "n" && answer !="y") continue;
                if (answer == "n" || answer == "no")
                {
                    Console.WriteLine("Thank you for visiting us");
                    break;
                }
                Console.WriteLine("Choose what to buy: Press 1|2|3|4");
                Console.WriteLine("1) Fruit");
                Console.WriteLine("2) Vegetables");
                Console.WriteLine("3) Meat");
                Console.WriteLine("4) Beverages");
                Console.WriteLine("===================================");
                int numbPressed = 0;
                bool ispressed = int.TryParse(Console.ReadLine(), out numbPressed);
                if (ispressed && numbPressed > 0 && numbPressed < 5)
                {
                    if (numbPressed == 1)
                    {
                        var fruitFiltered = Db.Foods.Where(x => x.Type.ToString() == "Fruit").ToList();
                        foreach (var item in fruitFiltered)
                        {
                            item.PrintAll();
                        }
                        Console.WriteLine($"Please write the name of the item you are going to buy");
                        var answerBuy = Console.ReadLine();
                        foreach (var item in fruitFiltered)
                        {
                            if (item.Name == answerBuy)
                            {
                                Console.WriteLine($"You have chosen to buy {item.Name} Thank you!");
                                temp += item.Price;
                            } 
                        }
                    }

                    if (numbPressed == 2)
                    {
                        var VegeFiltered = Db.Foods.Where(x => x.Type.ToString() == "Vegetable").ToList();
                        foreach (var item in VegeFiltered)
                        {
                            item.PrintAll();
                        }
                        Console.WriteLine($"Please write the name of the item you are going to buy");
                        var answerBuy = Console.ReadLine();
                        foreach (var item in VegeFiltered)
                        {
                            if (item.Name == answerBuy)
                            {
                                Console.WriteLine($"You have chosen to buy {item.Name} Thank you!");
                                temp += item.Price;
                            }
                        }

                    }

                    if (numbPressed == 3)
                    {
                        var MeatFiltered = Db.Foods.Where(x => x.Type.ToString() == "Meat").ToList();
                        foreach (var item in MeatFiltered)
                        {
                            item.PrintAll();
                        }
                        Console.WriteLine($"Please write the name of the item you are going to buy");
                        var answerBuy = Console.ReadLine();
                        foreach (var item in MeatFiltered)
                        {
                            if (item.Name == answerBuy)
                            {
                                Console.WriteLine($"You have chosen to buy {item.Name} Thank you!");
                                temp += item.Price;
                            }
                        }
                       
                    }

                    if (numbPressed == 4)
                    {
                        var beverageFiltered = Db.Foods.Where(x => x.Type.ToString() == "Beverages").ToList();
                        foreach (var item in beverageFiltered)
                        {
                            item.PrintAll();
                        }
                        Console.WriteLine($"Please write the name of the item you are going to buy");
                        var answerBuy = Console.ReadLine();
                        foreach (var item in beverageFiltered)
                        {
                            if (item.Name == answerBuy)
                            {
                                Console.WriteLine($"You have chosen to buy {item.Name} Thank you!");
                                temp += item.Price;
                            }
                        }
                 
                        
                       

                    }

                    Console.WriteLine($"your total cost is {temp}");
                    Console.WriteLine("Would you like to buy something else? Press Y/N");
                    answer = Console.ReadLine().ToLower();
                 
                }


            }
        }
    }
}

