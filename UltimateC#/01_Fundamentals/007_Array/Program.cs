/* Array 
 * The array is the most basic collection type in C#, 
 * storing multiple elements of the same type. 
 */

// Array is a Class
// int array elements are initialized to 0 by default
int[] numbers = new int[3];

//collections are indexed starting from zero

Console.WriteLine("Element at index 0 (position 1 ) is " + numbers[0]);
Console.WriteLine("Element at index 1 (position 2 ) is " + numbers[1]);
Console.WriteLine("Element at index 2 (position 3 ) is " + numbers[2]);

// Assigining array values
numbers[0] = 5;
numbers[1] = 6;
numbers[2] = 7;
//numbers[3] = 8; // IndexOutofRangeException

Console.WriteLine("Element at index 0 (position 1 ) is " + numbers[0]); //5
Console.WriteLine("Element at index 1 (position 2 ) is " + numbers[1]); //6
Console.WriteLine("Element at index 2 (position 3 ) is " + numbers[2]); //7

// Accessing elements from end of the array (using ^)
var firstFromLast = numbers[^1]; 
Console.WriteLine("firstFromLast = "+ firstFromLast);//7

var secondFromLast = numbers[^2];
Console.WriteLine("secondFromLast = " + secondFromLast);//6

/* Different ways to intialize an Array*/

int[] integers = new int[3];
integers[0] = 1;
integers[1] = 2;
integers[2] = 3;

int[] ints = new int[] { 1, 2, 3 };

int[] numbers2 = { 1, 2, 3 }; // I PREFER THIS ONE

var numbers3 = new  int[] { 1, 2, 3 };

//var numbers4 = { 1, 2, 3 }; // Cannot initialize an implicitly typed variable with an array ;


//Disadvantage of Arrays: Size of arrays is fixed and should always be defined beforehand




Console.ReadLine();