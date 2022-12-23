using NUnit.Framework;
using Services;

namespace Tests
{
    public class Tests
    {
        private Calculator Instance;
        [SetUp]
        public void Setup()
        {
            Instance = new Calculator();
        }

        [Test]
        public void AddNumbersWithNoInput()
        {
            var result = Instance.Add();
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void AddTwoPositiveNumbers()
        {
            var result = Instance.Add(45, 5);
            Assert.AreEqual(result, 50);
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            var result = Instance.Add(-55, -15);
            Assert.AreEqual(result, -70);
        }

        [Test]
        public void AddThreePositiveNumbers()
        {
            var result = Instance.Add(5, 10, 5);
            Assert.AreEqual(result, 20);
        }

        [Test]
        public void AddThreeNegativeNumbers()
        {
            var result = Instance.Add(-5, -10, -5);
            Assert.AreEqual(result, -20);
        }

        [Test]
        public void SubtractNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void SubtractThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }
        
        [Test]
        public void MultiplyTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreePositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void MultiplyThreeNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideNumbersWithNoInput()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoPositiveNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNegativeNumbers()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideTwoNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void DivideThreeNumbersWithZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfFive()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOf200()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfZero()
        {
            Assert.Inconclusive("Test not fully implemented");
        }

        [Test]
        public void FactorialOfNegativeNumber()
        {
            Assert.Inconclusive("Test not fully implemented");
        }
    }
}