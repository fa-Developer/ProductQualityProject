using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ConjuredProduct :Item, IProduct
    {
        public ConjuredProduct(int sellIn, int quality)
        {
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        public void Update()
        {
            
                this.SellIn--;
                this.Quality = (this.SellIn > 0) ? this.Quality - 2 : this.Quality - 4;
            if (this.Quality < 0)
                this.Quality = GildedRose.MINIMUM_QUALITY;


        }
    }
}
