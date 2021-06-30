using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items) => this.Items = Items;

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Name != "Aged Brie"   
                   &&item.Name!= "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = decreaseQuality(item.Quality);
                }
                else
                {
                    item.Quality = increaseQuality(item.Quality);
                    
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn--;

                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = decreaseQuality(item.Quality);
                    }

                    else item.Quality = 0;
                }
                else item.Quality = increaseQuality(item.Quality);
            }
        }

        int decreaseQuality(int quality)
        {
            if (quality > 0) return quality--;

            return quality;
        }

        int increaseQuality(int quality)
        {
            if (quality < 50) return quality++;

            return quality;
        }

    }
}
