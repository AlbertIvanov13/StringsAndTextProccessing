
List<string> bannedWords = Console.ReadLine().Split(", ").ToList();
string text = Console.ReadLine();

for (int i = 0; i < bannedWords.Count; i++)
{
	if (text.Contains(bannedWords[i]))
	{
		text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
		continue;
	}
}

Console.WriteLine(text);