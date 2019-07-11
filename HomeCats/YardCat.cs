using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats.HomeCats
{
    class YardCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Mmm! Mmm!");
        }

        public void Scratch()
        {
            Console.WriteLine("I scratch, but not much");
        }
    }
}
