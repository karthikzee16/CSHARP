/* OUT 
 * The out variable must be assigned a value or else the function throws an error
 * The variable itself is passed to the method, not its copy.
 */

// Defining function with out keyword


List<int> GetOnlyPositive(int[] numbers, out int countOfNonPostitive)
{
    countOfNonPostitive = 0;

    var result =new List<int>();


    foreach (var number in numbers) 
    {
        if (number > 0) 
        { 
        result.Add(number);
        }

        else if(number<0)
        {
            countOfNonPostitive++;
        }    
    }
    return result;


}

var test = GetOnlyPositive(new int[] { 1,-1,2,-5,5},out int countofNonPositive);

Console.WriteLine(countofNonPositive);

Console.ReadLine();