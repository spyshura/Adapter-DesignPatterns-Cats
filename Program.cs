using Adapter_cats.Adapters;
using Adapter_cats.HomeCats;
using Adapter_cats.WildCats;
using System;

namespace Adapter_cats
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Vas'ka";
            CatPrintInfo.PrintCatInfo(vaska);

            IWildCats tiger = new Tiger();
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatPrintInfo.PrintCatInfo(adapter);

        }
    }
}
