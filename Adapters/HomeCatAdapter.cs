using Adapter_cats.HomeCats;
using Adapter_cats.WildCats;

namespace Adapter_cats.Adapters
{
    class HomeCatAdapter : IHomeCat
    {
        private IWildCats _wildcat;
        public HomeCatAdapter(IWildCats wildcat)
        {
            _wildcat = wildcat;
        }
        public string Name {
            get { return _wildcat.Breed; }
            set { }
        }

        public void Meow()
        {
            _wildcat.Growl();
        }

        public void Scratch()
        {
            _wildcat.Scratch();
        }
    }
}
