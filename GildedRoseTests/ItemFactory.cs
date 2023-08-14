using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseTests
{
    public class ItemFactory
    {
        public Item CreateAndUpdateItem(string name, int sellIn, int quality)
        {
            ProductFactory prdFactory = new ProductFactory();
          IProduct prd= prdFactory.CreateProduct(name, sellIn, quality);
            IList<Item> Items = new List<Item> { (Item) prd };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            return Items[0];


        }
    }
}
