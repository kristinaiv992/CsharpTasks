using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Food
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public string Company { get; set; }
        public FoodType Type { get; set; }

        public Food(string name, int id, double price, string company, FoodType type)
        {
            Name = name;
            Id = id;
            Price = price;
            Company = company;
            Type = type;
        }

        public void PrintAll()
        {
            Console.WriteLine($"Name:{Name}, ** ID:{Id}, ** Price: {Price}, ** Company: {Company},**Type: {Type}");
        }

        

        public enum FoodType
        {
            Fruit,
            Vegetable,
            Meat,
            Beverages
        }
    }
}

