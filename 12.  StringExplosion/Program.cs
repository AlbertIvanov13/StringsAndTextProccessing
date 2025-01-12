
string[] text = Console.ReadLine().Split(">");

for (int i = 0; i < text.Length; i++)
{
	for (int j = 0; j < text[i].Length; j++)
	{
		if (char.IsDigit(text[i][j]))
		{
			if (text[i].Length >= 1)
			{
				text[i].Remove(j);
			}
			if (text[i].Length > 1)
			{
				if (char.IsLetter(text[i][j + 1]))
				{
					string newText = text[i].Substring(j + 1);
				}
			}
		}
	}
}