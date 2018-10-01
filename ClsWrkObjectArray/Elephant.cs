using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkObjectArray
{
   public class Elephant
    {
        // Instance fields 

        // Properties
        public string Name { get; set; }

        public int Size { get; set; }

        //
        public Elephant()
        {
                
        }

        public Elephant(string name , int size)
        {
            Name = name;
            Size = size;
        }


    }
}
