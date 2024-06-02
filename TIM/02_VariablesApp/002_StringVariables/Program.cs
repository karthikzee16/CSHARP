

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;


firstName = "Tim";
lastName = "Corey";
filePath = "C:\\Kar_Files";


//string verbatium (@) (escape characters are not applied)
filePath = @"C:\Kar_Files";


Console.WriteLine(firstName +""+ lastName);

//string interpolation ($) 
Console.WriteLine($"{firstName} {lastName}");

Console.WriteLine(@$"{firstName} is at C:\Kar_Files");
Console.WriteLine($@"{firstName} is at C:\Kar_Files");
Console.ReadLine();