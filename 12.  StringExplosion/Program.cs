
string[] text = Console.ReadLine().Split(">").ToArray();

int intRemove = 0;
int numberToAdd = 0;
int newNumber = 0;

bool isFound = false;

for (int i = 0; i < text.Length; i++)
{
	for (int j = 0; j < text[i].Length; j++)
	{
		if (char.IsLetterOrDigit(text[i][j]))
		{
			if (text[i].Length >= 1)
			{
				if (char.IsDigit(text[i][j]))
				{
					intRemove = int.Parse(text[i][j].ToString());
					intRemove += numberToAdd;
					if (intRemove > text[i].Length)
					{
						newNumber = intRemove - text[i].Length;
						numberToAdd += newNumber;
						text[i] = text[i].Remove(0, text[i].Length);
					}
					else
					{
						text[i] = text[i].Remove(0, intRemove);
						isFound = true;
					}
				}
				else if (newNumber > 0 && !isFound)
				{
					text[i] = text[i].Remove(0, newNumber);
				}
			}
		}
	}
}

Console.WriteLine(string.Join(">", text));