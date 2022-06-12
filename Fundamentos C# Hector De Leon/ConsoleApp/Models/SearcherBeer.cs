////////******* Exceptions Control

public class SearcherBeer
{
    List<Beer> beers = new List<Beer>()
    {
        new Beer() { alcohol=7, size=10, name="Pale ale", brand="Minerva"},
        new Beer() { alcohol=7, size=8, name="Stout", brand="Minerva"},
        new Beer() { alcohol=3, size=100, name="Piedra Lisa", brand="Colina"}
    };

    public SearcherBeer()
    {}
    

    public int GetSize(string Name)
    {
        var beer = (from b in beers
                    where b.name == Name
                    select b).First();
        
        if (beer == null)
            throw new BeerNotFoundException("Beer finished");

        return beer.size;
    }
}