using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        public const string GENERICPRD_NAMEEXP = "foo";
        public const string CONJURD = "Conjured Mana Cake";
        public const string AGED_BRIE = "Aged Brie";
        public const string BACKSTAGE = "Backstage passes to a TAFKAL80ETC concert";
        public const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        public const int MAXIMUM_QUALITY = 50;
        public const int MINIMUM_QUALITY = 0;
        public const int SELLIN_FIRSTVALUE = 6;
        public const int SELLIN_SECONDVALUE = 11;



        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var Item = Items[i];
                ((IProduct)Item).Update();
                 
                }
            }
        }
    }

