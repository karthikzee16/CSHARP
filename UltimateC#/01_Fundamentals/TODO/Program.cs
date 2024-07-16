
List<string> todos = new List<string>();
Console.WriteLine("Hello!");

bool repeat = true;
while (repeat)
{
    PrintOptions();
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "S" or "s":
            SeeAllToDOs();
            break;

        case "A" or "a":
            AddToDO();
            break;

        case "R" or "r":
            RemoveToDO();
            break;

        case "E" or "e":
            repeat = false;
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }

}


void PrintOptions()
{
    Console.WriteLine("");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S] See all TODOs");
    Console.WriteLine("[A] Add a TODO");
    Console.WriteLine("[R] Remove a TODO");
    Console.WriteLine("[E] Exit");
}

void SeeAllToDOs()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}). {todos[i]}");
        }
    }
}

void AddToDO()
{

    Console.Write("Enter the TODO description:");

    string userToDoInput = Console.ReadLine();

    //Empty description
    if (string.IsNullOrEmpty(userToDoInput))
    {
        Console.WriteLine("The description cannot be empty.");
        AddToDO();
    }

    //Non-unique description

    else if (todos.Contains(userToDoInput))
    {
        Console.WriteLine("The description must be unique.");
        AddToDO();
    }

    else
    {
        todos.Add(userToDoInput);
        Console.WriteLine($"TODO successfully added:[{userToDoInput}] ");
    }
    return;


}

void RemoveToDO()
{

    Console.WriteLine("Select the index of the TODO you want to remove:");
    SeeAllToDOs();

    //There are no TODOs at all
    if (todos.Count == 0)
    {
        return;
    }

    string userToDoInput = Console.ReadLine();

    //Empty index
    if (string.IsNullOrEmpty(userToDoInput))
    {
        Console.WriteLine("Selected index cannot be empty.");
        RemoveToDO();
    }

    bool isInt = int.TryParse(userToDoInput, out int userInt);


    //Invalid index 
    if (!isInt)
    {
        Console.WriteLine("The given index is not valid.");
        RemoveToDO();
    }


    //User inputs a correct index of a TODO.

    if (isInt)
    {
        if (userInt > todos.Count)
        {
            Console.WriteLine("The given index is not valid.");
            RemoveToDO();

        }
        Console.WriteLine($"TODO removed: [{todos[userInt - 1]}]");
        todos.RemoveAt(userInt - 1);
       
    }

    return;

}





