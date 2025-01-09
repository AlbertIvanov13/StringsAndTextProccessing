
List<string> bannedWords = Console.ReadLine().Split(", ").ToList();
string text = Console.ReadLine();

for (int i = 0; i < bannedWords.Count; i++)
{
	if (text.Contains(bannedWords[i]))
	{
		int index = text.IndexOf(bannedWords[i]);
		string oldValue = bannedWords[i];
		text.Replace(bannedWords[i], "x");
	}
}