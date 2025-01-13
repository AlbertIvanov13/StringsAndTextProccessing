
string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int totalSum = 0;
string newNumber = "";
int number = 0;

for (int i = 0; i < inputs.Length; i++)
{
	for (int j = 0; j < inputs[i].Length; j++)
	{
		if (char.IsUpper(inputs[i][j]))
		{
			for (int k = 0; k < inputs[i].Length; k++)
			{
				if (char.IsDigit(inputs[i][k]))
				{
					newNumber = inputs[i][k].ToString();
					if (char.IsDigit(inputs[i][k + 1]))
					{
						newNumber += inputs[i][k + 1];
					}
				}
				else
				{
					continue;
				}
				number = int.Parse(newNumber);
				char letterPositionn = char.Parse(inputs[i][j].ToString());
				int letterPosition = letterPositionn;
				int result = letterPosition - 'A' + 1;
				totalSum += number / result;
				break;
			}
		}
		else if (char.IsLower(inputs[i][j]))
		{
			char letterPositionn = char.Parse(inputs[i][j].ToString());
			int letterPosition = letterPositionn;
			int result = char.ToUpper(letterPositionn) - 'A' + 1;
			totalSum += result;
		}
	}
}