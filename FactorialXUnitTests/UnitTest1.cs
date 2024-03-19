using Microsoft.VisualStudio.TestPlatform.TestHost;
using FactorialApp;

namespace FactorialXUnitTests
{
    public class UnitTest1
    {
        public class FactorialCalculatorTests
        {
            [Theory]
            [InlineData(0, 1)]
            [InlineData(1, 1)]
            [InlineData(2, 2)]
            [InlineData(3, 6)]
            [InlineData(4, 24)]
            [InlineData(5, 120)]
            [InlineData(6, 720)]
            [InlineData(7, 5040)]
            [InlineData(8, 40320)]
            [InlineData(9, 362880)]
            [InlineData(10, 3628800)]
            [InlineData(11, 39916800)]
            [InlineData(12, 479001600)]
            [InlineData(13, 6227020800)]
            [InlineData(14, 87178291200)]
            public void FactorialCalculator_CalculatesFactorialCorrectly(int n, long expectedFactorial)
            {
                // Arrange
                var calculator = new Program();

                // Act
                long factorial = Methods.CalculateFactorial(n);
                
                

                // Assert
                Assert.Equal(expectedFactorial, factorial);
            }
        }
    }
}