using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Food;

namespace ConsoleApp1
{
    public static class Db
    {
        public static List<Food> Foods = new List<Food>()
        {
                new Food ("Apple" ,112, 12.5, "Mexico", FoodType.Fruit),
                new Food ("Mango" ,120, 19.5, "China", FoodType.Fruit),
                new Food ("Ananas",113, 13.5, "Australia", FoodType.Fruit),
                new Food ("Kiwi" ,114, 12.5, "Asia", FoodType.Fruit),
                new Food ("Onion" ,115, 12.5, "Mexico", FoodType.Vegetable),
                new Food ("Rukola",116, 13.5, "Maroco", FoodType.Vegetable),
                new Food ("Cucumber" ,117, 12.5, "Serbia", FoodType.Vegetable),
                new Food ("Letuce" ,118, 12.5, "Macedonia", FoodType.Vegetable),
                new Food ("Pork",222, 33.5, "USA",FoodType.Meat ),
                new Food("Lamb",282, 33.5, "USA", FoodType.Meat),
                new Food("Beef", 232, 33.5, "USA", FoodType.Meat),
                new Food("Coca-Cola", 446, 22.8, "USA", FoodType.Beverages),
                new Food("fanta", 546, 25.8, "Macedonia",FoodType.Beverages),
                new Food("Sprite", 646, 20.8, "England", FoodType.Beverages),
               };
    }
}
