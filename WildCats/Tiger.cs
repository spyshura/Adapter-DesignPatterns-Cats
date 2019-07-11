using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats.WildCats
{
    class Tiger : IWildCats
    {
        public string Breed { get { return "Тигр обыкновенный"; } }

        public void Growl()
        {
            Console.WriteLine("Grrrrrrrrrrrrr!");
        }

        public void Scratch()
        {
            Console.WriteLine("I have very sharp claws. I scrape to death...");
        }
    }
}
