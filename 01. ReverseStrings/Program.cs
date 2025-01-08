
while(true)
{
	string word = Console.ReadLine();
	if (word == "end")
	{
		break;
	}

	List<string> characters = new List<string>();
	for (int i = 0; i < word.Length; i++)
	{
		characters.Add(word[i].ToString());
	}

	characters.Reverse();

	Console.WriteLine($"{word} = {string.Join("", characters)}");
}