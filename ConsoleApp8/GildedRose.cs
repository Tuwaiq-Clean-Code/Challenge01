using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public bool QualityLessThan50(Item item)
        {
            return item.Quality < 50;
        }
        public bool QualityGraterThan0(Item item)
        {
            return item.Quality > 0;
        }
        public void AddValueToQuality(Item item, int value)
        {
            item.Quality = item.Quality + value;
        }
        public void QualityDefaultIncrement(Item item)
        {
            if (QualityLessThan50(item))
            {
                AddValueToQuality(item, 1);
            }
        }
        public void QualityDefaultDecrement(Item item)
        {
            if (QualityGraterThan0(item))
            {
                AddValueToQuality(item, -1);
            }
        }
        public bool hasName(Item item, string name)
        {
            return item.Name == name;
        }
        public bool hasAnyName(Item item, string FirstName, string SecondName, string ThirdName)
        {
            return (item.Name == FirstName || item.Name == SecondName || item.Name == ThirdName);
        }

        public void ChangeQualityWithDefaultNameBehavior(Item item)
        {
            if (hasName(item, "Aged Brie"))
            {
                QualityDefaultIncrement(item);
            }

            if (
                !hasAnyName(item,
                "Sulfuras, Hand of Ragnaros",
                "Backstage passes to a TAFKAL80ETC concert",
                "Aged Brie")
                )
            {
                QualityDefaultDecrement(item);
            }
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {

                ChangeQualityWithDefaultNameBehavior(Items[i]);

                if (hasName(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                {
                    QualityDefaultIncrement(Items[i]);

                    if (Items[i].SellIn < 11)
                    {
                        QualityDefaultIncrement(Items[i]);

                    }

                    if (Items[i].SellIn < 6)
                    {
                        QualityDefaultIncrement(Items[i]);
                    }
                }

                if (!hasName(Items[i], "Sulfuras, Hand of Ragnaros"))
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn >= 0)
                    continue;

                ChangeQualityWithDefaultNameBehavior(Items[i]);

                if (hasName(Items[i], "Backstage passes to a TAFKAL80ETC concert"))
                {
                    AddValueToQuality(Items[i], -Items[i].Quality);
                }

            }
        }
    }
}
