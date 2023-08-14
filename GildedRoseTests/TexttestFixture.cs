
using GildedRoseKata;

using System;
using System.Collections.Generic;

namespace GildedRoseTests
{
    public static class TexttestFixture
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            ProductFactory prdfactory = new ProductFactory();
            IList<Item> Items = new List<Item>{ (Item) prdfactory.CreateProduct("+5 Dexterity Vest",  10,  20),
             //   (Item) prdfactory.CreateProduct(GildedRose.AGED_BRIE,  2,  0),
                (Item) prdfactory.CreateProduct( "Elixir of the Mongoose",  5,  7),
             /**   (Item) prdfactory.CreateProduct(GildedRose.SULFURAS,  0,  80)
               ,  (Item) prdfactory.CreateProduct(GildedRose.SULFURAS,  -1,  80)
                ,(Item) prdfactory.CreateProduct(GildedRose.BACKSTAGE,  15,  20),
                 (Item) prdfactory.CreateProduct(GildedRose.BACKSTAGE,  10,  49),
                 (Item) prdfactory.CreateProduct(GildedRose.BACKSTAGE,  5,  49),**/
                 (Item) prdfactory.CreateProduct("Conjured Mana Cake",  3,  6),
                                // this conjured item does not work properly yet
                
            };

            var app = new GildedRose(Items);

            int days = 31;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }
    }
}
