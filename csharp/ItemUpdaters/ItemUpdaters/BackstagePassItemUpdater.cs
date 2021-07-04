using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.ItemUpdaters.ItemUpdaters
{
    public class BackstagePassItemUpdater : ItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        protected override int GetQualityValue(Item item)
        {
            if (item.SellIn < 0) return 0;

            var qualityValue = 0;

            if (item.SellIn < 5) qualityValue = 3;
            else if (item.SellIn < 10) qualityValue = 2;
            else qualityValue = 1;

            return item.Quality + qualityValue;
        }
    }
}
