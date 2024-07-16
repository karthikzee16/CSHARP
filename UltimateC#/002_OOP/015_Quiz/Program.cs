
//The value of uninitialized fields will be initialized with the default values
var lucky = new Dog("Lucky");

//Age is not initialized so it will be 0 for lucky


public class Dog
{
    public string Name;
    public int Age;

    public int fetch(int name) 
    {
        return 0;
    }

    // We cannot have two methods with the same names and parameters,
    // but a different return type, in a single class.

   /* public string fetch(int name) 
    { 
    
    }*/

    public Dog()
    {

    }

    public Dog(string name)
    {
        Name = name;
    }

    public Dog(string name, int age) 
    {
        Name = name;
        Age = age;
    
    }

}