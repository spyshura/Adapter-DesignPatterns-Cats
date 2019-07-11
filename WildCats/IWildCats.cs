using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats.WildCats
{
    interface IWildCats
    {
        string Breed { get;}
        void Growl();
        void Scratch();
    }
}
