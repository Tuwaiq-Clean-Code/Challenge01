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

        public bool ValidateName(string name)
        {
            return (name != "Aged Brie" && name != "Backstage passes to a TAFKAL80ETC concert" && name != "Sulfuras, Hand of Ragnaros");
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (ValidateName(Items[i].Name) && Items[i].Quality > 0)
                {
                    Items[i].Quality--;
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality++;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert" && Items[i].Quality < 50)
                        {
                            if (Items[i].SellIn < 11)
                            {
                                Items[i].Quality++;
                            }
                            if (Items[i].SellIn < 6)
                            {
                                Items[i].Quality++;
                            }
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
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Quality > 0)
                        {
                            if (ValidateName(Items[i].Name))
                            {
                                Items[i].Quality--;
                            }
                        }
                        else
                        {
                            Items[i].Quality -= Items[i].Quality;
                        }
                    }
                    else if (Items[i].Quality < 50)
                    {
                        Items[i].Quality++;
                    }
                }
            }
        }

    }
}
