using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[4];
            // array[0] = 44 ; 

            Elephant[] array = new Elephant[]
            {
                new Elephant("lyolds", 600),
                new Elephant("lars", 700),
                new Elephant("tony", 800),
                new Elephant("marcin" , 65), 
                new Elephant("abs" , 67), 
            };
            // create an object instance of a class : Elephant

            //Elephant lyold = new Elephant("lyold" , 600);
            //Elephant lars = new Elephant("lars", 700);
            //Elephant tony = new Elephant("tony", 800);
            

            // Assigning object values into Array object reference 

            //array[0] = lyold;
            //array[1] = lars;
            //array[2] = tony;

            // Display array objects 

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"The Name of Elephant:{array[i].Name} and size of {array[i].Size}");
            }
            Console.WriteLine("ForEach Loop ...........................");
            foreach (var elp in array)
            {
                Console.WriteLine($"The Name of Elephant:{elp.Name} and size of {elp.Size}");
            }

            Console.ReadKey();

        }
    }
}
