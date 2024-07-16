int a = 10;
int b = 5;


// arithmetic operators are evaluated left to right (Associativity)

Console.WriteLine("Addition:" + a+b) ; // will print: "Addition105" due to string concetanation

// We can take control of the order of evaluation by adding parentheses where we need them.
Console.WriteLine("Addition:" + (a+b)) ; // 15, (a+b) is evaluated first

//Console.WriteLine("Subtraction:" + a - b); // error since an int can not be subtracted from an string

Console.WriteLine("Subtraction:"+ (a-b)); // 5
Console.WriteLine("Multiplication:"+ a*b); //50, * has higher precedence so a*b happens first
Console.WriteLine("Divison:"+ a/b);// 2 , / has higher precedence so a/b happens first
Console.WriteLine("John"+" "+"Smith");// John Smith

//unary operators: require only one operand
++a;
Console.WriteLine("a = "+a);
b--;
Console.WriteLine("b = "+b);



/* Types of variables */


/* var is used to declare implicit type variables in C#, 
 * which means it tells the compiler to figure out the variable type at compilation time. 
 * A var variable must be initialized at the time of declaration. ​​
 * var can contain any type of data.
 */

// var variables  can be used when the type of result for an operation is not know

// implicitly typed variables
var word  = "ABC";
var number = 5;

//var numberCheck; // error : implicitly typed variables must be initialized

// explicitly typed variables
string word2 = "ABC";
int number2 = 5;


/*Read user input*/
Console.Write("Please enter any input:");
string userInput = Console.ReadLine();
Console.WriteLine("user typed: "+ userInput);



/*Debugging with Break points*/

// Press f9 on a line to add a breakpoint.

//select expression and  press shift + f9 to open quickwatch and reevaluate expression 
var result = "abc" + "def" + "ghi";


/* Watch windows can display several variables at a time while debugging. 
 * The QuickWatch dialog displays a single variable at a time, can  reevaluate expression  
 * and must be closed before debugging can continue.*/


Console.ReadLine();




