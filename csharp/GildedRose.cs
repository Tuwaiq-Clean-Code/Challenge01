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
            foreach (var item in Items)
            {                           
                if (item.Name != "Aged Brie" && 
                    item.Name != "Backstage passes to a TAFKAL80ETC concert" && 
                    item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = DecreaseQuality(item.Quality);
                }
                else
                {
                    item.Quality = IncreaseQuality(item.Quality);
                    item.Quality ++;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert" && item.SellIn < 11)
                        {
                            item.Quality = IncreaseQuality(item.Quality);

                            if (item.SellIn < 6)
                            item.Quality = IncreaseQuality(item.Quality);                            
                        }                    
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                 item.SellIn --;                

                if (item.SellIn < 0 && 
                    item.Name != "Aged Brie" && 
                    item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                        if (item.Name != "Sulfuras, Hand of Ragnaros")
                        {
                        item.Quality = DecreaseQuality(item.Quality);
                        }
                        
                        else item.Quality = 0;                        
                }
                    else item.Quality = IncreaseQuality(item.Quality);                                            
                }
            }


        int IncreaseQuality(int quality)
        {
            if (quality < 50) 
                return quality++;

            return quality;
        }


        int DecreaseQuality(int quality)
        {
            if (quality > 0)
                return quality--;

            return quality;
        }

    }
    }

