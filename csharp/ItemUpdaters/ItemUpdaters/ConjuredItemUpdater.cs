using csharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.ItemUpdaters.ItemUpdaters
{
    public class ConjuredItemUpdater : ItemUpdater
    {
        public override bool CanUpdate(Item item)
        {
            return item.Name == "Conjured Mana Cake";
        }

        protected override int GetQualityValue(Item item)
        {
            return item.Quality - 2;
        }
    }
}
