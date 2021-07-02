using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN.Items
{
    public class AgedBrieItem : BaseItem
    {
        public AgedBrieItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void EnterNewDay()
        {
            SellIn = SellIn - 1;
            Quality = Quality + 1;
        }
    }
}
