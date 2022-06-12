public class Beverage
{
    
    public string name {get; set;}
    public int size {get; set;}

    public Beverage(string name, int size)
    {
        this.name = name;
        this.size = size;
    }

    public void ToDrink(int amountYouDrank)
    {
        this.size -= amountYouDrank;
    }
}
