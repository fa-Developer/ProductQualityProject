﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class GenericProduct :Item, IProduct
    {



        public GenericProduct(int sellIn, int quality)
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
