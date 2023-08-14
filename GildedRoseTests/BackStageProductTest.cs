using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public  class BackStageProductTest:ItemFactory
    {
       
        [Fact]
        public void TestBackstagePrd_QualityIncrease()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 25, 7);
            Assert.Equal(8, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdSellInIsTenOrLess_QualityIncreaseTwice()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 10, 7);
            Assert.Equal(9, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdSellInIsFiveOrLess_QualityIncreaseBy3()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 5, 7);
            Assert.Equal(10, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdOutOfDate_QualityEqualsZero()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 0, 5);
            Assert.Equal(0, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdSellInMoreThanTen_QualityNotSuperior50()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 40, 49);
            Assert.Equal(50, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdSellInIsTenOrLess_QualityNotSuperior50()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 10, 49);
            Assert.Equal(50, item.Quality);
        }
        [Fact]
        public void TestBackstagePrdSellInIsFiveOrLess_QualityNotSuperior50()
        {
            Item item = CreateAndUpdateItem(GildedRose.BACKSTAGE, 5, 49);
            Assert.Equal(50, item.Quality);
        }
        
    }
}
