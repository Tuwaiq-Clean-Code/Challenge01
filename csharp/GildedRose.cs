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

        public bool lessThan50(Item item)
        {
            return item.Quality < 50;
        }
        public bool moreThan0(Item item)
        {
            return item.Quality > 0;
        }
        public bool hasName(Item item, string name)
        {
            return item.Name == name;
        }
        public void changeQualityValue(Item item, int value)
        {
            item.Quality = item.Quality + value;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (!hasName(Items[i], "Aged Brie") && !hasName(Items[i], "Backstage passes to a TAFKAL80ETC concert") && moreThan0(Items[i]) && !hasName(Items[i], "Sulfuras, Hand of Ragnaros"))
                {
                    changeQualityValue(Items[i],-1);
                }
                if (lessThan50(Items[i]))
                {
                        changeQualityValue(Items[i], 1);

                        if (hasName(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                        {
                            if (Items[i].SellIn < 11)
                            {
                                changeQualityValue(Items[i], 1);
                            }

                            if (Items[i].SellIn < 6)
                            {
                                changeQualityValue(Items[i], 1);
                            }
                        }
                }

                if (!hasName(Items[i], "Sulfuras, Hand of Ragnaros"))
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (!hasName(Items[i], "Aged Brie"))
                    {
                        if (!hasName(Items[i], "Backstage passes to a TAFKAL80ETC concert") && !hasName(Items[i], "Sulfuras, Hand of Ragnaros") && moreThan0(Items[i]))
                        {
                            changeQualityValue(Items[i], -1);
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else if (lessThan50(Items[i]))
                        {
                        changeQualityValue(Items[i], 1);
                    }
                }
            }
        }
    }
}
