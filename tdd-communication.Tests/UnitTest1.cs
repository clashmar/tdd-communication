using FluentAssertions;
using NUnit.Framework.Legacy;
using Sorting;

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

        [TestCase(new int[] { 1, 2, 3, 4 }, 2.5, TestName = "Return 2.5 when passed 1,2,3,4")]

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

        [TestCase(new Kata4.Opinion[] { Kata4.Opinion.LIKE }, Kata4.Opinion.LIKE, TestName = "One like = Like")]
        [TestCase(new Kata4.Opinion[] { Kata4.Opinion.LIKE, Kata4.Opinion.LIKE }, Kata4.Opinion.NEUTRAL, TestName = "Two like = neutral")]
        [TestCase(new Kata4.Opinion[] { Kata4.Opinion.LIKE, Kata4.Opinion.DISLIKE }, Kata4.Opinion.NEUTRAL, TestName = "Even like/dislike = neutral")]
        [TestCase(new Kata4.Opinion[] { Kata4.Opinion.LIKE, Kata4.Opinion.DISLIKE, Kata4.Opinion.LIKE, Kata4.Opinion.DISLIKE }, Kata4.Opinion.NEUTRAL, TestName = "Even like/dislike = neutral")]
        public void CheckOpinions(Kata4.Opinion[] opinionsArray, Kata4.Opinion expectedOpinion)
        {
            List<Kata4.Opinion> opinionsList = opinionsArray.ToList();
            Kata4.GetOpinion(opinionsList).Should().Be(expectedOpinion);

            //Kata4.GetOpinion();
        }

        [TestCase("test", "grfg", TestName = "Returns grfg when given test.")]
        [TestCase("Test", "Grfg", TestName = "Returns Grfg when given test.")]
        [TestCase("Test again 13!", "Grfg ntnva 13!", TestName = "Returns Grfg ntvna 13! when given Test again 13!")]
        public void CipherTest_1(string input, string expected)
        {
            Kata5.ConvertToCipher(input).Should().Be(expected);
        }

        [TestCase("--K---M-C--", 2, 3, "Cheese")]
        [TestCase("--K---M-C--", 2, 0, "No cheese")]
        [TestCase("--KM-C--", 3, 3, "Cheese party!")]
        public void CheeseTest(string chase, int catSpeed, int mouseSpeed, string expected)
        {
            Kata6.CheeseChasers(chase, catSpeed, mouseSpeed).Should().Be(expected);
        }

        [TestCase("--K-----CM-", 2, 3)]
        [TestCase("--K----M-C", 0, 0)]
        [TestCase("---CM-K", 2, 3)]
        public void CheeseTestError(string chase, int catSpeed, int mouseSpeed)
        {
            Assert.Throws<ArgumentException>(() => Kata6.CheeseChasers(chase, catSpeed, mouseSpeed));
        }

        [TestCase("--K---M-C--", 2, 3, "Cheese")]
        [TestCase("--K----C-M-", 1, -2, "Cheese")]
        [TestCase("--K-C-M-", 3, 2, "No Cheese")]
        [TestCase("--K-C-M-", 1, -1, "Cheese party!")]
        [TestCase("---C-M---K ", -1, -1, "Cheese")]
        public void NewCheeseTest(string chase, int catSpeed, int mouseSpeed, string expected)
        {
            Kata7.CheeseChasers(chase, catSpeed, mouseSpeed).Should().Be(expected);
        }

        [TestCase(new int[] { 2, 1, 3}, new int[] {1,2,3})]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] {  }, new int[] {  })]
        [TestCase(new int[] { 2, 1, 3, 6, 7, 4, 3 , 2, 1 }, new int[] { 1, 1, 2, 2, 3, 3, 4, 6, 7 })]
        public void BubbleSortTest(int[] arrayToSort, int[] expectedArray)
        {
            CollectionAssert.AreEqual(BubbleSort.Sort(arrayToSort), expectedArray);
        }

        [TestCase(new int[] { 2, 1, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 2, 1, 3, 6, 7, 4, 3, 2, 1 }, new int[] { 1, 1, 2, 2, 3, 3, 4, 6, 7 })]
        public void SelectionSortTest(int[] arrayToSort, int[] expectedArray)
        {
            CollectionAssert.AreEqual(SelectionSort.Sort(arrayToSort), expectedArray);
        }
    }
}