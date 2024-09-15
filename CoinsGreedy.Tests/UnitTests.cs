using Xunit;
using Models;

namespace CoinsGreedy.Tests
{
    public class CoinCalculatorTests
    {
        [Fact]
        public void UnitTest1()
        {
            var calculator = new CoinCalculator();
            int amount = 562;

            int result = calculator.CalculateMinCoins(amount);

            Assert.Equal(6, result); // Expected 6 coins (200+200+100+50+10+2)
        }

        [Fact]
        public void UnitTest2()
        {
            var calculator = new CoinCalculator();
            int amount = 0;

            int result = calculator.CalculateMinCoins(amount);

            Assert.Equal(0, result); // Expected 0 coins
        }

        [Fact]
        public void UnitTest3()
        {
            var calculator = new CoinCalculator();
            int amount = 1;

            int result = calculator.CalculateMinCoins(amount);

            Assert.Equal(1, result); // 1 coin of 1 unit
        }

        [Fact]
        public void UnitTest4()
        {
            var calculator = new CoinCalculator();
            int amount = 999;

            int result = calculator.CalculateMinCoins(amount);

            Assert.Equal(11, result); // Expected 11 coins (200x4, 100, 50, 20x2, 5, 2x2)
        }

        [Fact]
        public void UnitTest5()
        {
            var calculator = new CoinCalculator();
            int amount = 63;

            int result = calculator.CalculateMinCoins(amount);

            Assert.Equal(4, result); // Expected 4 coins (50, 10, 2, 1)
        }
    }
}
