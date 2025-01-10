
string text = Console.ReadLine();

List<string> encryptedText = new List<string>();

for (int i = 0; i < text.Length; i++)
{
	int upper = Convert.ToInt32(text[i]);
	int newChar = upper + 3;
	char newerChar = Convert.ToChar(newChar);
	encryptedText.Add(newerChar.ToString());
}

Console.WriteLine(string.Join("", encryptedText));