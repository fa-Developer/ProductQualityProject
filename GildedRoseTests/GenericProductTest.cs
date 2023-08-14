using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace GildedRoseTests
{
    public  class GenericProductTest :ItemFactory
    {
      
        #region Test_GenericPrds
        [Fact]
        public void TestGenericProduct_SellInAndQualityReduced()
        { 
            Item item = CreateAndUpdateItem(GildedRose.GENERICPRD_NAMEEXP, 4, 3);

            Assert.Equal(3, item.SellIn);
            Assert.Equal(2, item.Quality);
        }
        [Fact]
        public void TestGenericPrdOutOfDate_QualityDecreaseTwice()
        {
            Item item = CreateAndUpdateItem(GildedRose.GENERICPRD_NAMEEXP, 0, 5);

            Assert.Equal(3, item.Quality);
        }
        [Fact]
        public void TestGenericPrd_QualityNotNegative()
        {
            Item item = CreateAndUpdateItem(GildedRose.GENERICPRD_NAMEEXP, 3, 0);

            Assert.Equal(0, item.Quality);
        }
        [Fact]
        public void TestGenericPrdOutOfDate_QualityNotNegative()
        {
            Item item = CreateAndUpdateItem(GildedRose.GENERICPRD_NAMEEXP, 0, 0);

            Assert.Equal(0, item.Quality);
        }
        #endregion
    }
}
