using FluentAssertions;

namespace tdd_communication.Tests
 
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { }, TestName = "Return 0 when passed an empty string.")]
        public void SumMiddleNumbersTest_1(int[] array)
        {
            Kata1.SumMiddleNumbers(array).Should().Be(0);
        }

        [Test]
        [TestCase(new int[] { 2, 1, 3, 4 }, 5, TestName = "Return 5 when passed 2, 1, 3, 4.")]
        [TestCase(new int[] { 1 }, 0, TestName = "Return 0 when passed [1].")]
        public void SumMiddleNumbersTest_2(int[] array, int number)
        {
            Kata1.SumMiddleNumbers(array).Should().Be(number);
        }

        [TestCase(new int[] { 1, 2, 3, 4}, 2.5, TestName = "Return 2.5 when passed 1,2,3,4")]

        [TestCase(new int[] { 2 }, 2, TestName = "Return 2 on one value array")]

        public void CalculateMeanTest(int[] array, double expectedValue)
        {
            Kata2.CalculateMean(array).Should().Be(expectedValue);
        }

        [TestCase(new int[] { }, TestName = "Return argument exception error when passed empty array")]
        public void CalculateMeanTestEmptyArray(int[] array)
        {
            Assert.Throws<ArgumentException>(() => Kata2.CalculateMean(array));
        }

        [Test]
        [TestCase("", 0, TestName = "Return 0 when passed an empty string.")]
        [TestCase("a", 97, TestName = "Return 0 when passed an empty string.")]
        [TestCase("northcoders", 1195, TestName = "Return 0 when passed an empty string.")]
        [TestCase("Northcoders", 1163, TestName = "Return 0 when passed an empty string.")]
        public void SumCodesTest_1(string input, int output)
        {
            Kata3.SumCodes(input).Should().Be(output);
        }
    }
}