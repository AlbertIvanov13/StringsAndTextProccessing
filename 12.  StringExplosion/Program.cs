
string[] text = Console.ReadLine().Split(">");

int intRemove = 0;
for (int i = 0; i < text.Length; i++)
{
	for (int j = 0; j < text[i].Length; j++)
	{
		if (char.IsDigit(text[i][j]))
		{
			if (text[i].Length >= 1)
			{
				intRemove = int.Parse(text[i][j].ToString());
				text[i].Remove(j);
			}
			if (text[i].Length > 1)
			{
				if (char.IsLetter(text[i][j + 1]))
				{
					text[i] = text[i].Remove(0, intRemove);
				}
			}
		}
	}
}

Console.WriteLine(string.Join(">", text));