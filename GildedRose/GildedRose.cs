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
                if (Item.Name != AGED_BRIE && Item.Name != BACKSTAGE)
                { 
                    if (Item.Quality > 0)
                    {
                        if (Item.Name != SULFURAS)
                        {
                            Item.Quality = Item.Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Item.Quality < 50)
                    {
                        Item.Quality = Item.Quality + 1;

                        if (Item.Name == BACKSTAGE)
                        {
                            if (Item.SellIn < 11)
                            {
                                if (Item.Quality < 50)
                                {
                                    Item.Quality = Item.Quality + 1;
                                }
                            }

                            if (Item.SellIn < 6)
                            {
                                if (Item.Quality < 50)
                                {
                                    Item.Quality = Item.Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Item.Name != SULFURAS)
                {
                    Item.SellIn = Item.SellIn - 1;
                }

                if (Item.SellIn < 0)
                {
                    if (Item.Name != AGED_BRIE)
                    {
                        if (Item.Name != BACKSTAGE)
                        {
                            if (Item.Quality > 0)
                            {
                                if (Item.Name != SULFURAS)
                                {
                                    Item.Quality = Item.Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Item.Quality = Item.Quality - Item.Quality;
                        }
                    }
                    else
                    {
                        if (Item.Quality < 50)
                        {
                            Item.Quality = Item.Quality + 1;
                        }
                    }
                }
            }
        }
    }
}
