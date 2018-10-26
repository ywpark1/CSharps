using NUnit.Framework;
using SimpleCalculator;

namespace SimpleCalculator.UnitTests {
    [TestFixture]
    public class InputConverterTests {
        private InputConverter _inputConverter;

        [SetUp]
        public void Setup () {
            _inputConverter = new InputConverter ();
        }

        [Test]
        [TestCase ("123")]
        // [TestCase (1, "+", 2)]
        public void ConvertInputToNumeric_WhenCalled_ReturnsDoubleTypeValue (string argInput) {
            double result = _inputConverter.ConvertInputToNumeric (argInput);

            Assert.That (result, Is.EqualTo (123.0));
        }

        [Test]
        [TestCase ("a")]
        public void ConvertInputToNumeric_WhenCalled_ThrowException (string argInput) {
            var ex = Assert.Throws<System.ArgumentException> (() => _inputConverter.ConvertInputToNumeric (argInput));

            Assert.That (ex.Message, Is.EqualTo ("Expected a numeric value."));
        }
    }
}