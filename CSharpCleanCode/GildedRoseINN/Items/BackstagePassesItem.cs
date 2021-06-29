using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN.Items
{
    public class BackstagePassesItem : BaseItem
    {
        public BackstagePassesItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void EnterNewDay()
        {
            SellIn = SellIn - 1;
            Quality = Quality + SellIn switch
            {
                0 => 0,
                (<= 5) => 3,
                (<= 10) => 2,
                _ => 1
            };
        }
    }
}
