using Stringies;

namespace StringiesTest
{
	public class StringsInfoTests
	{
		[Theory]
		[InlineData("penisyaga", 8)]
		[InlineData("groobas", 4)]
		[InlineData("01aaa", 3)]
		[InlineData("a", 1)]
		
		public void UnequalCharsCount_CorrectStringGiven_ReturnCount(string inputString, int expectedResult)
		{
			var stringInfo = new StringsInfo();
			int actual = stringInfo.UnequalCharsCount(inputString);

			Assert.Equal(expectedResult, actual);
		}

		[Fact]
		public void UnequalCharsCount_EmptyStringGiven_ThrowArgumentException()
		{
			string emptyString = string.Empty;
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentException>(() => stringInfo.UnequalCharsCount(emptyString));
		}

		[Fact]
		public void UnequalCharsCount_NullGiven_ThrowArgumentNullException()
		{
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentNullException>(() => stringInfo.UnequalCharsCount(null));
		}

		[Theory]
		[InlineData("aaaa1", 4)]
		[InlineData("beeep144444", 3)]
		[InlineData("TwooInARow", 2)]
		[InlineData("100001", 0)]
		[InlineData("10001a", 1)]
		[InlineData("a0", 1)]
		public void EqualLettersCount_CorrectStringGiven_ReturnCount(string inputString, int expectedResult)
		{
			var stringInfo = new StringsInfo();
			int actual = stringInfo.EqualLettersCount(inputString);

			Assert.Equal(expectedResult, actual);
		}

		[Fact]
		public void EqualLettersCount_EmptyStringGiven_ThrowArgumentException()
		{
			string emptyString = string.Empty;
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentException>(() => stringInfo.EqualLettersCount(emptyString));
		}

		[Fact]
		public void EqualLettersCount_NullGiven_ThrowArgumentNullException()
		{
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentNullException>(() => stringInfo.EqualLettersCount(null));
		}

		[Theory]
		[InlineData("aaaa", 0)]
		[InlineData("Bee144444fff", 5)]
		[InlineData("2TwooInARow", 1)]
		[InlineData("a1", 1)]
		[InlineData("1a", 1)]
		public void EqualDigitsCount_CorrectStringGiven_ReturnCount(string inputString, int expectedResult)
		{
			var stringInfo = new StringsInfo();
			int actual = stringInfo.EqualDigitsCount(inputString);

			Assert.Equal(expectedResult, actual);
		}

		[Fact]
		public void EqualDigitsCount_EmptyStringGiven_ThrowArgumentException()
		{
			string emptyString = string.Empty;
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentException>(() => stringInfo.EqualDigitsCount(emptyString));
		}

		[Fact]
		public void EqualDigitsCount_NullGiven_ThrowArgumentNullException()
		{
			var stringInfo = new StringsInfo();

			Assert.Throws<ArgumentNullException>(() => stringInfo.EqualDigitsCount(null));
		}
	}
}