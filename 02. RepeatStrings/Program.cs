
string[] words = Console.ReadLine().Split().ToArray();

List<string> result = new List<string>();
for (int i = 0; i < words.Length; i++)
{
	string word = words[i];
	for (int j = 0; j < word.Length; j++)
	{
		result.Add(word);
	}
}

Console.WriteLine(string.Join("", result));