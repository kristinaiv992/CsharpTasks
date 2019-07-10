using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            firstTask.StringMessage("kate", "kiki", firstTask.Comparer);
            firstTask.StringMessages("kate", "kiki", firstTask.Compare);
            firstTask.StringMessage("kate", "kiki", firstTask.StringMagic);
            firstTask.StringMessage("kate", "kikicstojkicrelepagic", firstTask.StringMagicStart);
            firstTask.StringMessage("kate", "kikicstojkicrelepagic", firstTask.StringMagicSEnd);
        }
        
    }
}
