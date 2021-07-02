using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCleanCode.GildedRoseINN
{
    public abstract class BaseItem : Item, INewDayEnterable
    {
        private int _sellIn;
        private int _quality;
        protected int _maxQualityValue = 50;

        public int SellIn
        {
            get => _sellIn;
            set => _sellIn = value < 0 ? -1 : value;
        }
        public int Quality
        {
            get => _quality;
            set => _quality = SellIn <= 0 ? 0
                : IsQualityValueInRange(value) ? value
                : _maxQualityValue;
        }

        public BaseItem(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
        protected virtual bool IsQualityValueInRange(int quality) => quality >= 0 && quality <= _maxQualityValue;
        public abstract void EnterNewDay();
    }
}
