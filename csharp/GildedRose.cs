using csharp.ItemUpdaters;
using csharp.ItemUpdaters.ItemUpdaters;
using csharp.Models;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        ItemUpdaterLocator _itemUpdaterLocator;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;

            var itemUpdaters = new List<IItemUpdater>
            {
                new AgedBrieItemUpdater(),
                new NormalItemUpdater(),
                new SulfuraItemUpdater(),
                new BackstagePassItemUpdater(),
                new ConjuredItemUpdater()
            };
            _itemUpdaterLocator = new ItemUpdaterLocator(itemUpdaters);
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
                _itemUpdaterLocator.Locate(item).Update(item);
        }
    }
}
