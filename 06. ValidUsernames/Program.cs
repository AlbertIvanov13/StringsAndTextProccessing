
using System.Collections.Specialized;

string[] usernames = Console.ReadLine().Split(", ");

List<string> validNames = new List<string>();

foreach (string username in usernames)
{
	if (username.Length < 3 || username.Length > 16)
	{
		continue;
	}

	bool isValid = username.All(symbol => char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_');

	if (isValid)
	{
		validNames.Add(username);
	}
}

foreach (string name in validNames)
{
    Console.WriteLine(name);
}