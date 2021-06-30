using System.Collections.Generic;
using System.Linq;

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
            string [] pleaseDontBe = { "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" };
            
            for (var i = 0; i < Items.Count; i++)
            {
                
                if (!pleaseDontBe.Contains(Items[i].Name) && Items[i].Quality > 0)
                { 
                    Items[i].Quality = Items[i].Quality - 1;
                }
                else
                {
                    if (isBelow(Items[i].Quality, 50))
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == pleaseDontBe[1])
                        {
                            if (isBelow(Items[i].SellIn, 11) && isBelow(Items[i].Quality, 50))
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }

                            if (isBelow(Items[i].SellIn, 6) && isBelow(Items[i].Quality, 50))
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                        }
                    }
                }

                if (Items[i].Name != pleaseDontBe[2])
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (isBelow(Items[i].SellIn, 0))
                {
                    if (Items[i].Name != pleaseDontBe[0])
                    {
                        if (Items[i].Name != pleaseDontBe[1] && isBelow(0, Items[i].Quality) && Items[i].Name != pleaseDontBe[2])
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (isBelow(Items[i].Quality, 50))
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }
        
        public bool isBelow(int below, int more)
        {
            return below < more;
        }
    }
}
