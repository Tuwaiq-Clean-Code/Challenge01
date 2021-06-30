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

        public bool IsRightName(string Name) => Name != "Aged Brie" && Name != "Backstage passes to a TAFKAL80ETC concert"
        && Name != "Sulfuras, Hand of Ragnaros" ;
        public bool IsGreatThanZero(int value) => value > 0;
        public bool IsLessThanFifty(int value) => value < 50;



        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                if (IsRightName(item.Name)&&IsGreatThanZero(item.Quality))
                {
                    item.Quality -= 1;
                }
                else
                {
                    if (IsLessThanFifty(item.Quality))
                    {
                        item.Quality +=1;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && IsLessThanFifty(item.Quality))
                        {
                            if (item.SellIn < 11)
                            {
                                item.Quality += 1;
                            }

                            if (item.SellIn < 6 && IsLessThanFifty(item.Quality))
                            {
                                item.Quality += 1;
                            }
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0 && IsRightName(item.Name) && IsGreatThanZero(item.Quality))
                {
                    item.Quality -= 1;
                }
                    
                else if (IsLessThanFifty(item.Quality))
                        {
                    item.Quality += 1;
                        }

                else
                {
                    item.Quality = item.Quality - item.Quality;
                }

            }
            }
        }
    }

