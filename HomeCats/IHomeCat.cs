using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats.HomeCats
{
    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Scratch();
    }
}
