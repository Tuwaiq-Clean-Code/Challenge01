using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN.Items
{
    public class ConjuredItem : NormalItem 
    {
        public ConjuredItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void EnterNewDay()
        {
            var sellInValueBeforeDecreasing = SellIn;
            var qualityValueBeforeDecreasing = Quality;

            base.EnterNewDay();

            SellIn = SellIn - (sellInValueBeforeDecreasing - SellIn);
            Quality = Quality - (qualityValueBeforeDecreasing - Quality);
        }
    }
}
