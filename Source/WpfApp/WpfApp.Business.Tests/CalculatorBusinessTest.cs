using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WpfApp.Business.Tests
{
    public class CalculatorBusinessTest
    {
        [Fact]
        public void PassingSumTest()
        {
            CalculatorBusiness cb = new CalculatorBusiness();

            Assert.Equal(5, cb.Sum(2, 3));
        }

        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(5, 3, 8)]
        [InlineData(8, 2, 10)]
        public void PerformSum(int x, int y, int result)
        {
            CalculatorBusiness cb = new CalculatorBusiness();

            Assert.True(cb.Sum(x, y) == result);
        }
    }
}
