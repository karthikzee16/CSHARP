/* Lists 
 * Size of list is not fixed, and it can be changed
 */

//List is a Class , List is a generic type


List<string> words = new List<string>();

words.Add(string.Empty);
words.Add("Hello");

for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}
Console.WriteLine("----------");
/*---------*/

var words2 =new List<string> { "one","two"}; // List of count 2

foreach (var item in words2)
{
    Console.WriteLine(item);
}

/* Reassigning values to  elements of a list*/
words2[0] = "uno";
words2[1] = "duo";
//words2[3] = "tres"; // IndexOutofRangeException

Console.WriteLine("Add(\"three\")");
Console.WriteLine("Remove(\"duo\")");
words2.Add("three");
words2.Remove("duo");
words2.Remove("twenty two"); // it does nothing (no exception)

foreach (var item in words2)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------");
Console.WriteLine("RemoveAt(1)");
words2.RemoveAt(1); //removes elemnt at index 1 ("three is removed")

//words2.RemoveAt(7); // invalid index for this list, ArgumentOutOfRangeException

foreach (var item in words2)
{
    Console.WriteLine(item);
}

Console.WriteLine("----------");
Console.WriteLine("Adding range");
words2.AddRange(new[] { "three", "four", "five" });
foreach (var item in words2)
{
    Console.WriteLine(item);
}


int indexOF = words2.IndexOf("four");
Console.WriteLine("Index of \"four\" = "+indexOF);

indexOF = words2.IndexOf("fourty nine"); //if element not in least IndexOf returns -1;
Console.WriteLine("Index of \"fourty nine\" = " + indexOF);

Console.WriteLine("Contains \"five\"?: " + words2.Contains("five"));
Console.WriteLine("Contains \"fourty nine\"? " + words2.Contains("fourty nine"));

words2.Clear();
Console.WriteLine("Count of elemetns after clear:"+ words2.Count);

Console.Read();

 List<string> GetOnlyUpperCaseWords(List<string> words)
{ 
    var result = new List<string>();

    //your code goes here
    foreach (var word in words) 
    {
        if (result.Contains(word))
        {
            continue;
        }

        if (IsUperCase(word)) 
        {
            result.Add(word);
        }
       
    
    }

    return result;  
}
bool IsUperCase(string word)
{
    foreach (var letter in word)
    {

        if (!char.IsUpper(letter) )
        {
            return false;
           
        }
    }
    return true;
}
Console.Read();

