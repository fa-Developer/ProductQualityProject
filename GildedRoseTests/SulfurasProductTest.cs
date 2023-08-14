using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public  class SulfurasProductTest:ItemFactory
    {
       
        [Fact]
        public void TestSulfurasPrd_QualityIsConstant()
        {
            Item item = CreateAndUpdateItem(GildedRose.SULFURAS, 5, 80);
            Assert.Equal(80, item.Quality);
        }
        [Fact]
        public void TestSulfurasPrdOutOfDate_QualityIsConstant()
        {
            Item item = CreateAndUpdateItem(GildedRose.SULFURAS, 0, 80);
            Assert.Equal(80, item.Quality);
        }
       
    }
}
