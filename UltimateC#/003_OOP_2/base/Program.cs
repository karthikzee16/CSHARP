
/* Constructor from base class is called first 
   and then the constructor from derived class is called*/


/* base keyword*/
/* To pass the parameter to the base class constructor we use base() in derived class constructor*/
/* To use any base class member in any derived class we use base. */
Ingredient ingredient = new Ingredient(1);
Cheddar cheddar = new Cheddar(2,12);


Console.WriteLine(cheddar);


Console.ReadLine();


public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get;  }


    public virtual string Name => "Some Ingredient";
    public string PublicMethod() => "This is public method in Ingredient";


    /*Private methods can not be inherited*/
    private string PrivateMethod() => "This is Private method in Ingredient";

    protected string ProtectedMethod() => "This is Protected method in Ingredient";

    public override string ToString() => Name;
}



public class Cheddar : Ingredient
{

    /*To pass the parameter to base class we use base() */
    public Cheddar(int priceIfExtraTopping,int agedForMonth) :base(priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from Cheddar class");
        AgedForMonth = agedForMonth;

    }


   // using member of base class using base.Name
    public override string Name =>
       $"{base.Name}, more specifically, " +
       $"a cheddar cheese aged for {AgedForMonth} months";


    public int AgedForMonth { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        //  Console.WriteLine(PrivateMethod()); //private methods can not be inherited.
        Console.WriteLine(ProtectedMethod()); //protected members can be used in the derived classes, but they can't be used outside.*/
    }


}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatosIn100Grams { get; }

}

public class Mozzarella : Ingredient
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public string Name => "Mozzarella"; // NOT overriden
    public bool isLight { get; }
}

public class Pizza
{

    private List<Ingredient> _ingredients = new List<Ingredient> { };
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() =>
      $"This is a pizza with {string.Join(",", _ingredients)}";



}


