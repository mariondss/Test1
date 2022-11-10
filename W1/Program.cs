using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student(26037, "Marion", 0.0, 'F');
            stud1.DisplayDetails();
            stud1.AddScord(2.0);
            stud1.DisplayDetails();
            Console.ReadKey();
        }
    }
}
