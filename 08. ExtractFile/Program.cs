
string[] path = Console.ReadLine().Split(new char[] { ':', '\\', '.' }, StringSplitOptions.RemoveEmptyEntries);

string disk = path[0];
string folderName = path[1];
string subfolderName = path[2];
string fileName = path[3];
string fileExtension  = path[4];

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");