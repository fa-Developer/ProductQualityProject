using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace GildedRoseTests
{
    public  class AgedBrieProductTest:ItemFactory
    {
      

        [Fact]
        public void TestAgedBrie_QualityIncrease()
        {
            Item item = CreateAndUpdateItem(GildedRose.AGED_BRIE, 3, 4);
            Assert.Equal(5, item.Quality);
        }
        [Fact]
        public void TestAgedBrie_QualityNotSuperiorTo50()
        {
            Item item = CreateAndUpdateItem(GildedRose.AGED_BRIE, 3, 50);
            Assert.Equal(50, item.Quality);
        }
        [Fact]
        public void TestAgedBrieOutOfDate_QualityIncreaseTwice()
        {
            Item item = CreateAndUpdateItem(GildedRose.AGED_BRIE, 0, 3);
            Assert.Equal(5, item.Quality);
        }
        [Fact]
        public void TestAgedBrieOutOfDate_QualityNotSuperiorTo50()
        {
            Item item = CreateAndUpdateItem(GildedRose.AGED_BRIE, 0, 49);
            Assert.Equal(50, item.Quality);
        }
      
    }
}
