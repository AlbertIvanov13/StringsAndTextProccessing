
string firstWord = Console.ReadLine();
string secondWord = Console.ReadLine();


for (int i = 0; i < secondWord.Length; i++)
{
	if (secondWord.Contains(firstWord))
	{
		int index = secondWord.IndexOf(firstWord);
		secondWord = secondWord.Remove(index, firstWord.Length);
		continue;
	}
	else
	{
		break;
	}
}

Console.WriteLine(secondWord);