
string input = Console.ReadLine();

List<string> newStrings = new List<string>();
List<string> strings = new List<string>();

for (int i = 0; i <= input.Length - 1; i++)
{
	if (i == input.Length - 1)
	{
		newStrings.Add(input[i].ToString());
		break;
	}
	if (input[i] == input[i + 1])
	{
		strings.Add(input[i].ToString());
	}
	else
	{
		if (strings.Count < 1)
		{
			newStrings.Add(input[i].ToString());
			strings = new List<string>();
			continue;
		}
		else
		{
			foreach (string s in strings)
			{
				if (s == input[i].ToString())
				{
					newStrings.Add(s);
					break;
				}
			}
		}
		strings = new List<string>();
	}
}

Console.WriteLine(string.Join("", newStrings));