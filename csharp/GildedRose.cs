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

       
        public (int, int) AgedBrie(int quality, int sellIn)
        {
            sellIn -= 1;

            if (sellIn < 0 && quality < 50)
            {
                if ((quality + 2) < 50)
                {
                    quality += 2;
                }
                else
                {
                    quality = 50;
                }
            }
            else
            {
                if ((quality + 1) < 50)
                {
                    quality += 1;
                }
                else
                {
                    quality = 50;
                }
                
            }

            return (sellIn, quality);
        }

        public (int, int) Backstage(int quality, int sellIn)
        {
            sellIn -= 1;

            if(sellIn > 9 && quality < 50)
            {
                if ((quality + 1) < 50)
                {
                    quality += 1;
                }
                else
                {
                    quality = 50;
                }
            }
            else if (sellIn > 4 && sellIn < 10)
            {
                if ((quality + 2) < 50)
                {
                    quality += 2;
                }
                else
                {
                    quality = 50;
                }
            }
            else if ( sellIn > -1 && sellIn<5)
            {
                if ((quality + 3) < 50)
                {
                    quality += 3;
                }
                else
                {
                    quality = 50;
                }

            }
            else
            {
                quality = 0;
            }

            return (sellIn, quality);
        }
       
        public (int,int) OtherThanSulfuras(int quality, int sellIn)
        {
            sellIn -= 1;

            if ((quality - 1) > 0)
            {
                quality -= 1;
            }
            else
            {
                quality = 0;
            }
            
            return (sellIn, quality);
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    if (Items[i].Name == "Aged Brie")
                    {
                        Items[i].Quality = AgedBrie(Items[i].Quality, Items[i].SellIn).Item2;
                        Items[i].SellIn = AgedBrie(Items[i].Quality, Items[i].SellIn).Item1;
                    }

                    else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        Items[i].Quality = Backstage(Items[i].Quality, Items[i].SellIn).Item2;
                        Items[i].SellIn = Backstage(Items[i].Quality, Items[i].SellIn).Item1;
                    }

                    else
                    {
                        Items[i].Quality = OtherThanSulfuras(Items[i].Quality, Items[i].SellIn).Item2;
                        Items[i].SellIn = OtherThanSulfuras(Items[i].Quality, Items[i].SellIn).Item1;

                    }

                }

            }
        }
    }
}
