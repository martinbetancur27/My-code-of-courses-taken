// LINQ

public class BarData
{
    public string Name {get; set;}

    public List<Beverage> beverages = new List<Beverage>();

    public BarData(string Name)
    {
        this.Name = Name;
    }
}