public class Bar
{
    public string Name {get; set;}

    public List<Beer> beers = new List<Beer>();

    public Bar(string Name)
    {
        this.Name = Name;
    }
}