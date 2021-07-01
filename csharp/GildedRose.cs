using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        Item[] Items;
        public GildedRose(Item[] Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Length; i++)
            {
                if (!Items[i].Name.Equals("Aged Brie") && !Items[i].Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                {
                    if (Items[i].Quality > 0)
                    {
                        if (!Items[i].Name.Equals("Sulfuras, Hand of Ragnaros"))
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (!Items[i].Name.Equals("Sulfuras, Hand of Ragnaros"))
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (!Items[i].Name.Equals("Aged Brie"))
                    {
                        if (!Items[i].Name.Equals("Backstage passes to a TAFKAL80ETC concert"))
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (!Items[i].Name.Equals("Sulfuras, Hand of Ragnaros"))
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = 0;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
