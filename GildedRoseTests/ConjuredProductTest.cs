using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GildedRoseTests
{
    public class ConjuredProductTest:ItemFactory
    {
        [Fact]
        public void TestConjuredPrd_QualityNotNegative()
        {
            Item item = CreateAndUpdateItem(GildedRose.CONJURD, 7, 1);
            Assert.Equal(0, item.Quality);
        }
        [Fact]
        public void TestConjuredPrdOutOfDate_QualityNotNegative()
        {
            Item item = CreateAndUpdateItem(GildedRose.CONJURD, 0, 2);
            Assert.Equal(0, item.Quality);
        }
    }
}
