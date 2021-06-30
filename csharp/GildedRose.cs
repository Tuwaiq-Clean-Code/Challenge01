using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {

        public const string BackstagePasses = "Backstage passes to a TAFKAL80ETC concert";
        public const string AgedBrie = "Aged Brie";
        public const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";
        public const string ConjouredCake = "Conjured Mana Cake";

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public int QualityDecrease(Item item)
        {
            return item.Quality = item.Quality - 1;
        }

        public int QualityIncrease(Item item)
        {
            return item.Quality = item.Quality + 1;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != AgedBrie && item.Name != BackstagePasses && item.Name != SulfurasHandOfRagnaros && item.Quality > 0)
                {

                    QualityDecrease(item);

                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;

                        if (item.Name == BackstagePasses && item.Quality < 50)
                        {
                            if (item.SellIn < 11)

                                QualityIncrease(item);

                        }


                    }
                }

                if (item.Name != SulfurasHandOfRagnaros)

                    item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    if (item.Name != AgedBrie)
                    {
                        if (item.Name != BackstagePasses && item.Name != SulfurasHandOfRagnaros && item.Quality > 0)

                            QualityDecrease(item);

                        else

                            item.Quality = item.Quality - item.Quality;
                    }
                    else
                    {
                        if (item.Quality < 50)

                            QualityIncrease(item);

                    }
                }
            }
        }
    }

    }

