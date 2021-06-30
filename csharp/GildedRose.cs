using System;
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
            string [] Unwanted = { "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros" };

            for (var i = 0; i < Items.Count; i++)
            {
                var NameChecked = Array.Exists(Unwanted, x => x == Items[i].Name);

                if (NameChecked == false && Items[i].Quality > 0)
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }
        
               if (Items[i].Quality < 50)
               Items[i].Quality = Items[i].Quality + 1;
        

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }


                if (Items[i].SellIn < 0)
                {
                    if (NameChecked == false)
                    {
                        if (Items[i].Quality > 0)
                        {
                              Items[i].Quality = Items[i].Quality - 1;
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    
                }
            }
        }
    }
}
