using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality = DecreaseQuality(Items[i].Quality);
                    }
                }
                else
                {
                    Items[i].Quality = IncreaseQuality(Items[i].Quality);
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert" && Items[i].SellIn < 11)
                        {
                            Items[i].Quality = IncreaseQuality(Items[i].Quality);
                            if (Items[i].SellIn < 6)
                            {
                            Items[i].Quality = IncreaseQuality(Items[i].Quality);
                            }
                        }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn--;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality = DecreaseQuality(Items[i].Quality);
                            }
                        }
                        else
                        {
                            Items[i].Quality = DecreaseQuality(Items[i].Quality, Items[i].Quality);
                        }
                    }
                    else
                    {
                       Items[i].Quality = IncreaseQuality(Items[i].Quality);
                    }
                }
            }
        }
        public int IncreaseQuality(int quality)
        {
            if (quality < 50)
                return quality + 1;
            
                return quality;
        }
        public int DecreaseQuality(int quality, int amount = 1)
        {
            if (quality > 0)
                return quality - amount;
           
                return quality;
        }

    }
}