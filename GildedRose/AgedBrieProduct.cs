using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class AgedBrieProduct : Item,IProduct
    {
        public AgedBrieProduct(int sellIn, int quality)
        {
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        public void Update()
        {
            
                this.SellIn--;
                this.Quality = (this.SellIn > 0) ? this.Quality + 1 : this.Quality + 2;
                if (this.Quality > 50)
                    this.Quality = GildedRose.MAXIMUM_QUALITY;
            
        }
    }
}
