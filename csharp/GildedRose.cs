using System.Collections.Generic;
using System.Data;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            this._items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var category = Categorize(item);
                category.UpdateItem(item);
            }
        }

        private static ItemCategory Categorize(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new Sulfuras();
            }

            if (item.Name == "Aged Brie")
            {
                return new AgedBrie();
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackstagePass();
            }

            if (item.Name == "Conjured Mana Cake")
            {
                return new Conjured();
            }

            return new ItemCategory();
        }
    }
}