

//Ask and print user name until the input is "exit"
string userName;
do
{
    Console.WriteLine("Please enter your name (type \"exit\" to quit):");
    userName = Console.ReadLine();

    if (userName != "exit") 
    {
        if (userName.ToUpper() == "TIM") 
        {
            Console.WriteLine("Welcome Proffessor");
        }
        else
        {
            Console.WriteLine($"Welcome  {userName}");
        }
       
    }

} while (userName!="exit");



