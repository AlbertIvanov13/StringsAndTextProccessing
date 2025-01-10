
using System.Linq;
using System.Numerics;

string path = Console.ReadLine();

int startIndex = 0;
int endIndex = 0;
for (int i = 1; i < path.Length; i++)
{
	if (char.IsLetterOrDigit(path[i]))
	{
		if (path[i - 1].ToString() == "\\")
		{
			startIndex = i - 1;
		}
		
		if (path[i - 1].ToString() == ".")
		{
			endIndex = i - 1;
		}

	}
}

string file = path.Substring(startIndex + 1);
string fileName = "";
string fileExtension = "";
for (int i = 0; i < file.Length; i++)
{
	int index = file.IndexOf('.');
	fileName = file.Substring(0, index);
	fileExtension = file.Substring(index + 1);
}

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");