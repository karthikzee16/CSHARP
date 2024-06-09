
/* List are internally implemented using arrays
 * To Initialize a List, Length of List need not be defined 
 * List grows in size automatically when elements are added into it.
 */


//creates a list of strings
List<string> firstName = new List<string>();

firstName.Add("Tim");
firstName.Add("Bob");
firstName.Add("Sue");
firstName.Add("Jan");

//List uses Count instead of Length
for (int i = 0; i < firstName.Count; i++)
{
    Console.WriteLine($"Element at position {i + 1} is {firstName[i]}");
}


//List<T> - generic
List<int> ages = new List<int>();



string data = "Tim,Sue,Bob,Jan,Frank";
//using ToList()
List<string> firstNames = data.Split(',').ToList();

firstNames.Add("Kar");

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Element at position {i + 1} is {firstNames[i]}");
}

Console.ReadLine();