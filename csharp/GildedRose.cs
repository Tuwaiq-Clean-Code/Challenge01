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

        public void decreaseItemQuality(Item item, int value) => item.Quality -= value;
        public void increaseItemQuality(Item item, int value) => item.Quality += value;
        public bool isQualityLessThanLevel(Item item, int qualityLevel) => item.Quality < qualityLevel;
        public bool isQualityGreaterThanLevel(Item item, int qualityLevel) => item.Quality > qualityLevel;
        public bool containsName(Item item, string[] names)
        {
            foreach (var name in names)
                if (name == item.Name)
                    return true;
            return false;
        }
        public void QualityDefaultDecrement(Item item)
        {
            if (isQualityGreaterThanLevel(item, 0))
                decreaseItemQuality(item, 1);
        }

        public void QualityDefaultIncrement(Item item)
        {
            if (isQualityLessThanLevel(item, 50))
                increaseItemQuality(item, 1);
        }

        public void DefaultQualityChange(Item item)
        {
            if (containsName(item, new string[] { "Aged Brie" }))
            {
                QualityDefaultIncrement(item);
            }
            if (
                !containsName(item,
                new string[] {
                "Sulfuras, Hand of Ragnaros",
                "Backstage passes to a TAFKAL80ETC concert",
                "Aged Brie"})
                )
            {
                QualityDefaultDecrement(item);
            }
        }
        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                DefaultQualityChange(item);

                if (containsName(item, new string[] { "Backstage passes to a TAFKAL80ETC concert" }))
                {
                    QualityDefaultIncrement(item);

                    if (item.SellIn < 11)
                        QualityDefaultIncrement(item);

                    if (item.SellIn < 6)
                        QualityDefaultIncrement(item);
                }

                if (!containsName(item, new string[] { "Sulfuras, Hand of Ragnaros" }))
                    item.SellIn = item.SellIn - 1;

                if (item.SellIn >= 0)
                    continue;

                if (containsName(item, new string[] { "Backstage passes to a TAFKAL80ETC concert" }))
                    decreaseItemQuality(item, item.Quality);

                DefaultQualityChange(item);
            }
        }
    }
}
