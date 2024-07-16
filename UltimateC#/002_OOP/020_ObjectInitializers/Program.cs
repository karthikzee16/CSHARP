//creating objects usin ObjectInitializer

//ObjectInitializer only works if the Property has a public settor

/* ObjectInitializer forces us to specify the properties names
 * it may be considered more readable, especially with many parameters.
 */

/* in practice, the constructors are used more often.
 * But if we are okay with some properties not always being explicitly assigned a value, 
 * using an object initializer will also work for us. */

var person1 = new Person
{
    Name = "Karthik",  // name will be Karthik, constructor is called first and then the ObjectInitializer
    YearofBirth = 1997,
    NickName = "zee"
};

var person2 = new Person("John")
{
    Name = "Karthik",  // name will be Karthik, constructor is called first and then the ObjectInitializer
    YearofBirth = 1997,
    NickName = "zee"

};

person2.Name = "karth";
//person2.NickName = "z";  // will not work, since it is init Property

//while using ObjectInitializer ,unassigned Properties will be assigned a default value of there data type

var person3 = new Person("Karthik")
{
    // YearofBirth will be assigned 0 (int)
    // NickName WILL be assigned null (string)

};


/* Computed properties */
Console.WriteLine(person1.Description); 

Console.ReadLine();

class Person
{
    //prop
    public string Name { get; set; }

    public int YearofBirth { get; set; }

    /* using init access modifier in settor
     * we can assign a value to a property only during object creation
     * and it can not be accessed anywhere else
     */

    public string NickName { get; init; }



    public Person() { } // defined so that var person = new Person{} ObjectInitializer can be used

    public Person(string name) // defined so that  var person = new Person("name"){} ObjectInitializer can be used
    {
        Name = name;
    }

    /* Computed properties */
    /* Similar to parameterless methods
     * The result is computed each time the property is used
     * Avoid adding performance heavy/ complex code inside computed properties
     */

    public string Description => $" A person with name {Name} has year of birth {YearofBirth}";

   // above code is  similar to 
    //public string Description
    //{
    //    get 
    //    {
    //        return $"A person with name {Name} has year of birth {YearofBirth}";
    //    }
    //}
    // 


}