
namespace _07._CharacterMultiplier
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strings = Console.ReadLine().Split();

			Console.WriteLine(Multiplier(strings[0], strings[1]));
		}

		public static decimal Multiplier(string firstString, string secondString)
		{
			bool isTrue = false;
			decimal sum = 0;
			List<string> firstStringElements = new List<string>();
			List<string> secondStringElements = new List<string>();
			for (int i = 0; i <= firstString.Length; i++)
			{
				for (int j = i; j < secondString.Length; j++)
				{
					if (j == firstString.Length)
					{
						if (firstString.Length > secondString.Length)
						{
							firstStringElements.Add(firstString.Substring(i));
						}
						else if (firstString.Length < secondString.Length)
						{
							secondStringElements.Add(secondString.Substring(j));
						}
						break;
					}
					else
					{
						sum += char.Parse(firstString[i].ToString()) * char.Parse(secondString[j].ToString());
					}
					break;
				}

				if (i == secondString.Length)
				{
					firstStringElements.Add(firstString.Substring(i));
				}
			}
			if (firstString.Length > secondString.Length)
			{
				for (int i = 0; i < firstStringElements[0].Length; i++)
				{
					sum += char.Parse(firstStringElements[0][i].ToString());
				}
			}
			else if (firstString.Length < secondString.Length)
			{
				for (int i = 0; i < secondStringElements[0].Length; i++)
				{
					sum += char.Parse(secondStringElements[0][i].ToString());
				}
			}
			return sum;
		}
	}
}