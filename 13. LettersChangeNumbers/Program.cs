
string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int totalSum = 0;
string newNumber = "";

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
				int number = int.Parse(newNumber);
				char letterPositionn = char.Parse(inputs[i][j].ToString());
				int letterPosition = letterPositionn;
				int result = letterPosition - 'A' + 1;
				totalSum += number / result;
			}
		}
		else if (char.IsLower(inputs[i][j]))
		{

		}

		if (char.IsUpper(inputs[i][inputs[i].Length - 1]))
		{

		}
		else if (char.IsLower(inputs[i][inputs[i].Length - 1]))
		{

		}
	}
}