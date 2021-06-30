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
                if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    DecreaseQuality(item);
                }
                else
                {
                    IncreaseQuality(item);
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
					if (QualityIsLow(item))
					{
                        item.Quality = item.Quality + 1;
                        return;
                    }
                    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                            DecreaseQuality(item);
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
            }
        }

		private bool QualityIsLow(Item item)
		{
            return item.Quality < 50;
        }

		private void IncreaseQuality(Item item)
		{
            if (QualityIsLow(item))
            {
                item.Quality = item.Quality + 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11 && item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }

                    if (item.SellIn < 6 && item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }

		private void DecreaseQuality(Item item)
		{
            if (item.Quality > 0 && item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.Quality = item.Quality - 1;
            }
        }
	}
}
