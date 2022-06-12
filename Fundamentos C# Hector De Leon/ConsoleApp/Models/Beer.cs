public class Beer : Beverage, IAlcoholicBeverage
{
    public int alcohol {get; set;}
    public string brand {get; set;}

    public Beer(string name, int size): 
    base( name, size)
    {
    }

    public Beer() : base(null, 0)
    {}

    public void PrintMaximumAllowed()
    {
        Console.WriteLine("Maximum allowed is 10 bottles");
    }
}
