//null means lack of value


// int is not nullable by default
//int age1 = null;

// int?  (to make int nullable)


int? age = null;

bool? birthday = null;


string nonNullableString = "This string cannot be null.";
string? nullableString = null;

// This will cause a compile-time warning if you try to assign null to a non-nullable string
// nonNullableString = null; // Uncommenting this line will cause a warning

if (nullableString == null)
{
    Console.WriteLine("The nullable string is null.");
}
else
{
    Console.WriteLine("The nullable string is not null: " + nullableString);
}

nullableString = "Now it has a value!";

if (nullableString == null)
{
    Console.WriteLine("The nullable string is null.");
}
else
{
    Console.WriteLine("The nullable string is not null: " + nullableString);
}




