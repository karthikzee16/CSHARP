
/*
 * To Intialize an Array
 * The length of an array should  be specified and Length of Array is Fixed
 * To increase length of array - use Resize()
 */


/* Different ways to intialize an Array*/

int[] integers = new int[3];
integers[0] = 1;

int[] ints = new int[] { 1, 2, 3 };

int[] numbers = { 1, 2, 3 };


string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "Sue";
firstNames[2] = "Bob";
firstNames[3] = "Jane";
firstNames[4] = "Kar";

for (int i = 0; i < firstNames.Length; i++) 
{
    Console.WriteLine($"The first name at position {i+1} is {firstNames[i]}");
}

firstNames[0] = "Timothy";
Console.WriteLine(firstNames[0]);

// firstNames[5] = "IndexOutofBounds"; //IndexOutofBounds


/*---------*/
string data = "Tim,Sue,Bob,Jan,Frank";

string[] firstNames2 = data.Split(',');

for (int i = 0; i < firstNames2.Length; i++)
{
    Console.WriteLine($"The first name at position {i+1} is {firstNames2[i]}");
}

//To get last element of array
Console.WriteLine("last element of array is : "+ firstNames2[firstNames2.Length - 1 ]);







Console.ReadLine();
