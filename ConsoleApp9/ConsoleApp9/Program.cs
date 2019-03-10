using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car("honda", 40_000, "mouse grey");
            Car b = new Car("dihatsu", 9_000, "grey/green");

            Garage mygarage = new Garage();
            mygarage.Add(a);
            mygarage.Add(b);

            foreach(var item in mygarage)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(mygarage[4]);
            Console.WriteLine();
            Console.WriteLine(mygarage["dihatsus"]);
        }
    }
}
