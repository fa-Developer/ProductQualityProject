using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackStageProduct :Item, IProduct
    {



        public BackStageProduct(int sellIn,int quality)
        {
            this.SellIn = sellIn;
            this.Quality = quality;
        }
        public void Update()
        {
          
                this.SellIn--;
                this.Quality++;
                if (this.SellIn < GildedRose.SELLIN_SECONDVALUE) this.Quality++;
                if (this.SellIn < GildedRose.SELLIN_FIRSTVALUE) this.Quality++;
                if (this.SellIn <= 0) this.Quality = GildedRose.MINIMUM_QUALITY;
                if (this.Quality > 50) this.Quality = GildedRose.MAXIMUM_QUALITY;
            
        }

    }
}
