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
        public bool isLessThan50(Item item)
        {
            return item.Quality < 50;
        }


        public bool isGreaterThanZero(Item item)
        {
            return item.Quality > 0;
        }


        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (ValidateName(item.Name) && isGreaterThanZero(item))
                {
                    item.Quality--;
                }
                else
                {
                    if (isLessThan50(item))
                    {
                        item.Quality++;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && isLessThan50(item))
                        {
                            if (item.SellIn < 11)
                            {
                                item.Quality++;
                            }
                            if (item.SellIn < 6)
                            {
                                item.Quality++;
                            }
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn--;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Backstage passes to a TAFKAL80ETC concert" && isGreaterThanZero(item))
                        {
                            if (ValidateName(item.Name))
                            {
                                item.Quality--;
                            }
                        }
                        else
                        {
                            item.Quality -= item.Quality;
                        }
                    }
                    else if (isLessThan50(item))
                    {
                        item.Quality++;
                    }
                }
            }
        }


    }
}
