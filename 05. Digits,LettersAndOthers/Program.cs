
string input = Console.ReadLine();

List<char> digits = new List<char>();
List<char> letters = new List<char>();
List<char> characters = new List<char>();

for (int i = 0; i < input.ToString().Length; i++)
{
	if (char.IsDigit(input.ToString()[i]))
	{
		digits.Add(input.ToString()[i]);
	}
	else if (char.IsLetter(input.ToString()[i]))
	{
		letters.Add(input.ToString()[i]);
	}
	else if (char.IsAscii(input[i]))
	{
		characters.Add(input.ToString()[i]);
	}
}

Console.WriteLine(string.Join("", digits));
Console.WriteLine(string.Join("", letters));
Console.WriteLine(string.Join("", characters));