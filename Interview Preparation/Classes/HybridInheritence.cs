using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Preparation.Classes
{
    public class HybridInheritence : Employee
    {
        public HybridInheritence()
        {
            Console.WriteLine("HybridInheritence constructor called");
            Console.WriteLine("Employee class is a parent class for this class.");
        }
    }
}
