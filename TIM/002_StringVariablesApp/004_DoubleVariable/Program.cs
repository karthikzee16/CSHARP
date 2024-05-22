
// doubles can have decimal points (1.43 , 15 , 69.0)
// integers can go in a double
// double has precision of 16 
double averagAge;

averagAge = (43 + 22 + 62) / 3; //42 (since all operators are int)
Console.WriteLine(averagAge);

averagAge = (43 + 22 + 62) / 3.0;  // 42.333333333333336
Console.WriteLine(averagAge);


Console.ReadLine();