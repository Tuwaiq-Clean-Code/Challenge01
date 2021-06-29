﻿using System.Collections.Generic;

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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" 
                    && Items[i].Quality > 0 && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {                    
                            Items[i].Quality = Items[i].Quality - 1;
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert" && Items[i].SellIn < 11 
                            && Items[i].Quality < 50)
                        {                                                          
                            Items[i].Quality = Items[i].Quality + 1;  
                            
                            if (Items[i].SellIn < 6 && Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;                                
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0 && Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                       if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Quality > 0 && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {                              
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else if (Items[i].Quality < 50)
                    {                        
                     Items[i].Quality = Items[i].Quality + 1;                        
                    }
                }
            }
        }
    }

