using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN.Items
{
    public class SulfuraItem : BaseItem
    {
        protected int _maxQualityValue = 80;
        public int SellIn
        {
            get => 0;
            set { }
        }

        public int Quality
        {
            get => 80;
            set { }
        }

        public SulfuraItem(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }
        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
        protected override bool IsQualityValueInRange(int quality) => true;

        public override void EnterNewDay() { }
    }
}
