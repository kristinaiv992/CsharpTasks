using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class GenericServiceClass<T> where T : Pet
    {

        public void AddPet(T input) 
        {
            Db.Pets.Add(input);   
        }

        public void RemovePet1(string name) 
        {
            var item = Db.Pets.Find(x => x.Name == name);
            Db.Pets.Remove(item);
        }

        public void FindByAge(int age)
        {
            var item = Db.Pets.Find(x => x.Age == age);
        }

        public void FindbyType(string type)
        {
            var item = Db.Pets.Find(x => x.Type == type);
        
        }








    }
}
