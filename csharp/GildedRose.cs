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

        private void DecrementQuality(int i)
        {
            if (Items[i].Quality > 0)
            {
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }
            }
        }

        private void IncrementQuality(int i)
        {
            if (Items[i].Quality < 50)
            {
                Items[i].Quality = Items[i].Quality + 1;
            }
        }

        private void UpdateQualityForItems(int i)
        {
            IncrementQuality(i);
            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Items[i].SellIn < 11)
                {
                    IncrementQuality(i);
                }

                if (Items[i].SellIn < 6)
                {
                    IncrementQuality(i);
                }
            }
        }

        private void UpdateQualityForExpiredItems(int i)
        {
            if (Items[i].Name != "Aged Brie")
            {
                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecrementQuality(i);
                }
                else
                {
                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
                }
            }
            else
            {
                IncrementQuality(i);
            }
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecrementQuality(i);
                }
                else
                {              
                    UpdateQualityForItems(i);
                }
                
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    UpdateQualityForExpiredItems(i);
                }
            }
        }
    }
}
