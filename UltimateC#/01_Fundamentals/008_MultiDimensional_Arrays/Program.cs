int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 0, 1, 3 } };
FindMax(numbers);

//Declaring Multi Dimensional Array
char[,] letters = new char[2, 3];


letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
//letters[0, 3] = 'D'; // IndexOutofRangeException
letters[1, 2] = 'D';

/* Two ways to declare Multi Dimensional Arrays */
char[,] letters2 = { {'a','b' },{ 'c','d'}};
var letters3 = new char[,] { { 'a', 'b' }, { 'c', 'd' } };


/* To print elements of 2D array */
var height = letters.GetLength(0); // to get number of rows
var width = letters.GetLength(1); // to goet number of columns

Console.WriteLine(letters.Length);//6

for (var i = 0; i < height; i++) 
{
    

    for (var j = 0; j < width; j++)
    {
        

        Console.WriteLine($"letters[{i},{j}] = {letters[i,j]}");

    }

}
Console.ReadLine();


static int FindMax(int[,] numbers)
{
    int max = -int.MaxValue;
    var height = numbers.GetLength(0);
    var width = numbers.GetLength(1);
    if (height == 0 || width == 0)
    {
        return -1;
    }

    //foreach loop
    foreach (var element in numbers) 
    { 
    if (element > max)
        {
            max = element;
        }
    }

    return max;
    //your code goes here
}

/*Both for and foreach loops have the same time complexity of O(m×n) for iterating through a 2D array.*/
