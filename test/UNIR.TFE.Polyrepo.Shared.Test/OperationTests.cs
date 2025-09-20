namespace UNIR.TFE.Polyrepo.Shared.Test
{
    public class OperationTests
    {
        private class TestOperation : IOperation
        {
            public string Key => "test";
            public decimal Execute(decimal a, decimal b) => a + b;
        }

        [Fact]
        public void Key_ShouldReturnExpectedValue()
        {
            // Arrange
            var operation = new TestOperation();

            // Act
            var key = operation.Key;

            // Assert
            Assert.Equal("test", key);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1.5, 2.5, 4.0)]
        public void Execute_ShouldReturnExpectedResult(decimal a, decimal b, decimal expected)
        {
            // Arrange
            var operation = new TestOperation();

            // Act
            var result = operation.Execute(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}