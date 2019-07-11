using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats.HomeCats
{
    class PedigreedCats : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meow! Meow!");
        }

        public void Scratch()
        {
            Console.WriteLine("I not scratch!");
        }
    }
}
