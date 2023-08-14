using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class ProductFactory:IFactory
    {
        public IProduct CreateProduct(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case GildedRose.BACKSTAGE: return new BackStageProduct(sellIn, quality);
                case GildedRose.SULFURAS: return new SulfurasProduct(sellIn, quality);
                case GildedRose.AGED_BRIE: return new AgedBrieProduct(sellIn, quality);
                default: return new GenericProduct(sellIn, quality);

            }

        }
    }
}
