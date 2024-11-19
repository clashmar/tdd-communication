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
    }
}