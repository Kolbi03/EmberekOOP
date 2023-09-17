using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ember ember1 = new Ember("Aladin", "2000.01.01", "Budapest");
            Ember ember2 = new Ember("Leonidasz", "2001.01.01", "Budapest");
            Ember ember3 = new Ember("Rajmund", "2002.01.01", "Budapest");

            Console.WriteLine(ember1);
            Console.WriteLine(ember2);
            Console.WriteLine(ember3);

            Ember.Feltolt();

            

            Console.ReadKey();
        }
    }
}
