using System.Globalization;

DateTime today = DateTime.Now;
Console.WriteLine(today);
Console.WriteLine(today.ToString("MMM dd, yyyy hh:mm:tt zzz"));


// 	Parse() - Converts the string representation of a date and time to its DateTime
// 	equivalent by using the conventions of the current culture.
DateTime birthday = DateTime.Parse("6/11/1997");
Console.WriteLine(birthday);

//Ignore culture and parse the date in specified format
DateTime birthday2 = DateTime.ParseExact("6/11/1997","d/M/yyyy",CultureInfo.InvariantCulture);
Console.WriteLine(birthday2);

Console.ReadLine();


