using Adapter_cats.HomeCats;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_cats
{
    class CatPrintInfo
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье: ");
            Console.WriteLine(string.Format("Имя кота: {0}", cat.Name));
            Console.Write("Вид мяуканья: ");
            cat.Meow();
            Console.Write("Вид царапанья: ");
            cat.Scratch();

            Console.WriteLine();
        }
    }
}
