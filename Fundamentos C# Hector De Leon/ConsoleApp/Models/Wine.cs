class Wine: Beverage, IAlcoholicBeverage
{
    public int alcohol {get; set;}

    public Wine (string nameWine, int sizeWine):
    base(nameWine, sizeWine)
    {}

    public void PrintMaximumAllowed()
    {
        Console.WriteLine("Maximum allowed is 3 glasses");
    }
}