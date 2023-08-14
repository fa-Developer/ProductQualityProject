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
            throw new NotImplementedException();
        }

    }
}
