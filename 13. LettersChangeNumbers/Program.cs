
string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

double totalSum = 0;
string newNumber = "";
double number = 0;
char letterPosition = 'A';

for (int i = 0; i < inputs.Length; i++)
{
	newNumber = "";
	for (int j = 0; j < inputs[i].Length; j++)
	{
		if (char.IsDigit(inputs[i][j]))
		{
			newNumber += inputs[i][j];
		}
		else
		{
			continue;
		}
	}
	for (int k = 0; k < inputs[i].Length; k++)
	{
		if (char.IsLetter(inputs[i][k]))
		{
			if (k == inputs[i].Length - 1)
			{
				if (char.IsUpper(inputs[i][k]))
				{
					char letterPositionn = char.Parse(inputs[i][k].ToString());
					letterPosition = char.ToUpper(letterPositionn);
					int result = letterPosition - 'A' + 1;
					totalSum -= result;
				}
				else if (char.IsLower(inputs[i][k]))
				{
					char letterPositionn = char.Parse(inputs[i][k].ToString());
					letterPosition = char.ToUpper(letterPositionn);
					int result = letterPosition - 'A' + 1;
					totalSum += result;
				}
			}
			else if (char.IsUpper(inputs[i][k]))
			{
				number = int.Parse(newNumber);
				char letterPositionn = char.Parse(inputs[i][k].ToString());
				letterPosition = char.ToUpper(letterPositionn);
				int result = letterPosition - 'A' + 1;
				totalSum += number / result;
			}
			else if (char.IsLower(inputs[i][k]))
			{
				number = int.Parse(newNumber);
				char letterPositionn = char.Parse(inputs[i][k].ToString());
				letterPosition = char.ToUpper(letterPositionn);
				int result = letterPosition - 'A' + 1;
				totalSum += number * result;
			}
		}
	}
}

Console.WriteLine($"{totalSum:f2}");