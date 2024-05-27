int[] input = { 1, 2, 3, 4 };

int[] output = new int[4];
int runningSum = 0;
for (int i = 0; i < input.Length; i++) 
{
    runningSum = runningSum + input[i];
    output[i] = runningSum;

}

Console.WriteLine(output);



       



   