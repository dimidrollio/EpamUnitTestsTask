using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringies
{
	public class StringsInfo
	{
		public int UnequalCharsCount(string inputStr)
		{
			ArgumentNullException.ThrowIfNull(inputStr);

			if (inputStr.Length == 0)
			{
				throw new ArgumentException("string is empty", nameof(inputStr));
			}

			int maxCount = 1;
			int actualCount = 1;
			int startIndex = 0;

			for (int i = 0; i < inputStr.Length - 1; i++)
			{
				if (inputStr[startIndex..(i + 1)].Contains(inputStr[i + 1]))
				{
					if (maxCount < actualCount)
					{
						maxCount = actualCount;
					}
					startIndex = i + 1;
					actualCount = 1;
				}
				else
				{
					actualCount++;
					if (maxCount < actualCount)
					{
						maxCount = actualCount;
					}
				}
			}

			return maxCount;
		}

		public int EqualLettersCount(string inputStr)
		{
			ArgumentNullException.ThrowIfNull(inputStr);

			if (inputStr.Length == 0)
			{
				throw new ArgumentException("Input string cannot be null", inputStr);
			}

			if (inputStr.Length == 1)
			{
				return IsLatin(inputStr[0]) ? 1 : 0;
			}


			int maxCount = 0;
			int actualCount = 0;

			for (int i = 0; i < inputStr.Length - 1; i++)
			{
				if (IsLatin(inputStr[i]) && actualCount < 1) actualCount = 1;

				if (IsLatin(inputStr[i + 1]))
				{
					if (inputStr[i] == inputStr[i + 1]) actualCount++;
					else
					{
						maxCount = actualCount < maxCount ? maxCount : actualCount;
						actualCount = 1;
					}
				}
				else 
				{
					maxCount = actualCount < maxCount ? maxCount : actualCount;
					actualCount = 0;
				}
			}

			maxCount = actualCount < maxCount ? maxCount : actualCount;

			return maxCount;

			bool IsLatin(char c) => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
		}

		public int EqualDigitsCount(string inputStr)
		{
			ArgumentNullException.ThrowIfNull(inputStr);

			if (inputStr.Length == 0)
			{
				throw new ArgumentException("Input string cannot be null", inputStr);
			}

			if (inputStr.Length == 1)
			{
				return char.IsDigit(inputStr[0]) ? 1 : 0;
			}


			int maxCount = 0;
			int actualCount = 0;

			for (int i = 0; i < inputStr.Length - 1; i++)
			{
				if (char.IsDigit(inputStr[i]) && actualCount < 1) actualCount = 1;

				if (char.IsDigit(inputStr[i + 1]))
				{
					if (inputStr[i] == inputStr[i + 1]) actualCount++;
					else
					{
						maxCount = actualCount < maxCount ? maxCount : actualCount;
						actualCount = 1;
					}
				}
				else
				{
					maxCount = actualCount < maxCount ? maxCount : actualCount;
					actualCount = 0;
				}
			}

			if (actualCount > maxCount) maxCount = actualCount;

			return maxCount;
		}
	}
}
