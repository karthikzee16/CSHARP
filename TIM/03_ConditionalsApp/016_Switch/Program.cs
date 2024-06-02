//string firstName = Console.ReadLine();


//switch (firstName.ToLower())
//{
//    //fall through
//    case "sue":
//	case "tim":
//        Console.WriteLine("Hello Professor");
//        break;
//    case "tom":
//        Console.WriteLine("Hello tom");
//        break;
//    //if no case matches, default is executed
//    default :
//        Console.WriteLine("I don't know you");
//        break;

//}


string input = Console.ReadLine();
bool isint= int.TryParse(input,out int age);

if (isint) 
{ 
    age = int.Parse(input);

    switch (age)
    {
        
        case >= 0 and <= 18:
            Console.WriteLine("You are a child");
            break;

        case > 18 and <= 66:
            Console.WriteLine("You should have a job");
            break;
             
        case > 66:
            Console.WriteLine("Hopefully you are retiring soon");
            break;

        default:
            Console.WriteLine("Age was not in expected range");
            break;

    }
}






Console.ReadLine();