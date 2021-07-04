using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.ItemUpdaters.ItemUpdaters
{
    public class AgedBrieItemUpdater : ItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Aged Brie";
        }

        protected override int GetQualityValue(Item item)
        {
            return item.Quality + (item.SellIn < 0 ? 2 : 1);
        }
    }
}
