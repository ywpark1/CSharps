using NUnit.Framework;
using SimpleCalculator;

namespace Tests {
    [TestFixture]
    public class CalculatorEngineTests {

        private CalculatorEngine _calculatorEngine;

        [SetUp]
        public void Setup () {
            _calculatorEngine = new CalculatorEngine ();
        }

        [Test]
        [TestCase (1, "add", 2)]
        [TestCase (1, "+", 2)]
        public void Calculate_AddsTwoNumbers_ReturnsAddedValue (int num1, string operation, int num2) {
            double result = _calculatorEngine.Calculte (num1, operation, num2);

            Assert.That (result, Is.EqualTo (3));
        }

        [Test]
        [TestCase (1, "subtract", 2)]
        [TestCase (1, "-", 2)]
        public void Calculate_SubtractsTwoNumbers_ReturnsSubtractedValue (int num1, string operation, int num2) {
            double result = _calculatorEngine.Calculte (num1, operation, num2);

            Assert.That (result, Is.EqualTo (-1));
        }
    }
}