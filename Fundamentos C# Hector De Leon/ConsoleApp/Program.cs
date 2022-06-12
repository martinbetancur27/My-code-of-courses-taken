using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;


//char charLetter = 'a'; //just one quote

//float floatNumber = 18.65f; // Add to end f for decimal

//int number = null; //no se permite
//int? number = null; //? allow be nullable

//var varInt = 158; // specify very good the variable name

//object person = new {name = "Martin", lastname = "Betancur"}; // I lose the attributes

//var person = new {name = "Martin", lastname = "Betancur"}; // I get attributes

//Console.WriteLine(person.lastname);



//**************** Create object of class

/*Beverage beverage = new Beverage("Pepsi", 1000);
beverage.ToDrink(500);
Console.WriteLine(beverage.size);*/

// Create object of inherence class
/*Beer beer = new Beer("Corona", 900);
beer.ToDrink(500);
Console.WriteLine("beer size " + beer.size);*/



//**************** Create array

/*int [] array = new int[3] {0, 1, 2};

int numberOne = array[0];
Console.WriteLine(numberOne);

foreach (var item in array)
{
    Console.WriteLine(item);
}*/



//**************** Create List

/*List<string> myList = new List<string>();

myList.Add("Hola");
myList.Add("como");
myList.Add("esta");
myList.Add("usted");
myList.Remove("usted");

foreach (var item in myList)
{
    Console.WriteLine(item);
}*/



//**************** Create object List

/*List<Beer> listBeers = new List<Beer>();
listBeers.Add(new Beer("Aguila", 500));
listBeers.Add(new Beer("Pilsen", 700));
listBeers.Add(new Beer("Reds", 800));

foreach (var item in listBeers)
{
    Console.WriteLine(item);
}*/



//**************** Inherence

/*
Beer myBeer = new Beer("Corona", 344);
Console.WriteLine(myBeer.name);
*/



//**************** Interface

/*
myBeer.PrintMaximumAllowed();

var myWine = new Wine("Gato Negro", 10);
PrintRecommended(myWine);

static void PrintRecommended(IAlcoholicBeverage beberage)
{
    beberage.PrintMaximumAllowed();
}*/



//***************** DB Connection

//BeerDB beerdb = new BeerDB();

            // Insert new beer

/*var newBeer = new Beer("Pale Ale", 15);
newBeer.brand = "Minerva";
newBeer.alcohol = 6;

beerdb.Add(newBeer);*/

            // Update beer

/*var updateBeer = new Beer("Pale Ale", 5);
updateBeer.brand = "Minerva";
updateBeer.alcohol = 5;

beerdb.Update(updateBeer, 4);*/

            //Delete beer

//beerdb.Delete(4);

            //Get all beers

/*var beers = beerdb.Get();

foreach (var beer in beers)
{
    Console.WriteLine(beer.name);
}*/



//**************** Object Serialization

//*******   Object to JSON - Serialization

/*Beer myBeer = new Beer("Corona", 344);
string myJson = JsonSerializer.Serialize(myBeer);
//save file objeto.txt with structure Json
File.WriteAllText("objeto.txt", myJson);*/

//*******   JSON to Object - Deserialization

/*string myJson = File.ReadAllText("objeto.txt");
Beer beer = JsonSerializer.Deserialize<Beer>(myJson);
Console.WriteLine(beer.name);*/



//****************  HTTP

        //******* HTTP - methods async

/*string url = "http://jsonplaceholder.typicode.com/posts";
HttpClient client = new HttpClient();

var httpResponse = await client.GetAsync(url);

if (httpResponse.IsSuccessStatusCode)
{
    var content = await httpResponse.Content.ReadAsStringAsync();

    //Enable case-insensitive property name matching with System.Text.Json
    var options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    List<Post> posts =
    JsonSerializer.Deserialize<List<Post>>(content, options);

    foreach (var post in posts)
    {
        Console.WriteLine(post.Title);
    }
}*/

        //Ejemplo
        /*var res = client.GetAsync(url);
        Console.WriteLine("I can wait");
        await res;
        Console.WriteLine("I can not wait");*/


        /////******* HTTP - POST

/*string url = "http://jsonplaceholder.typicode.com/posts";
var client = new HttpClient();

Post post = new Post()
{
    UserId = 50,
    Body = "Hi, how are you?",
    Title = "Welcome message"
};

//Enable case-insensitive property name matching with System.Text.Json
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var data = JsonSerializer.Serialize<Post>(post, options);
HttpContent content =
    new StringContent(data, System.Text.Encoding.UTF8, "application/json");

var httpResponse = await client.PostAsync(url, content);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    var postResult = JsonSerializer.Deserialize<Post>(result, options);

    Console.WriteLine(postResult.Body + " " + postResult.Id);
}*/


        //////******* HTTP - PUT

/*string id_update = "99";
string url = "http://jsonplaceholder.typicode.com/posts";
url += "/" + id_update;

var client = new HttpClient();

Post post = new Post()
{
    UserId = 50,
    Body = "Hi, how are you?",
    Title = "Welcome message"
};

//Enable case-insensitive property name matching with System.Text.Json
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

var data = JsonSerializer.Serialize<Post>(post, options);
HttpContent content =
    new StringContent(data, System.Text.Encoding.UTF8, "application/json");

var httpResponse = await client.PutAsync(url, content);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    var postResult = JsonSerializer.Deserialize<Post>(result, options);

    Console.WriteLine(postResult.Body + " " + postResult.Id);
}*/


        //////******* HTTP - DELETE

/*string id_delete = "99";
string url = "http://jsonplaceholder.typicode.com/posts";
url += "/" + id_delete;

var client = new HttpClient();
var httpResponse = await client.DeleteAsync(url);

if (httpResponse.IsSuccessStatusCode)
{
    var result = await httpResponse.Content.ReadAsStringAsync();

    Console.WriteLine("Fulfilling the conditional means code between 200 and 299 --> It has been removed");
}*/



//**************** GENERICS - file Service -> SendRequest

/*var beer = new Beer()
{alcohol = 2, size = 500, brand = "Colima", name = "Ticús"};

SendRequest<Beer> service = new SendRequest<Beer>();
var BeerRequest = await service.Send(beer);

Console.WriteLine(BeerRequest.brand);*/



//**************** LINQ

/*List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};

var number7 = numbers.Where(d => d == 7).FirstOrDefault();
Console.WriteLine(number7);

var numbersOrders = numbers.OrderBy(d => d);

foreach (var number in numbersOrders)
{
    Console.WriteLine(number);
}

var sumTotal = numbers.Sum(d => d);
Console.WriteLine(sumTotal);

List<Beer> beers = new List<Beer>()
{
    new Beer() { alcohol=7, size=10, name="Pale ale", brand="Minerva"},
    new Beer() { alcohol=2, size=5, name="Pilsen", brand="Bavaria"}
};

var beerOrder = from d in beers
                orderby d.brand
                select d;

foreach (var beer in beerOrder)
{
    Console.WriteLine(beer.name + " - " + beer.brand);
}*/


        //////******* LINQ - Complex objects

/*List<Bar> bars = new List<Bar>()
{
    new Bar("El bar")
    {
        beers = new List<Beer>()
        {
            new Beer() { alcohol=7, size=10, name="Pale ale", brand="Minerva"},
            new Beer() { alcohol=2, size=5, name="Pilsen", brand="Bavaria"}
        }
    },

    new Bar("El bar 2")
    {
        beers = new List<Beer>()
        {
            new Beer() { alcohol=7, size=8, name="Stout", brand="Minerva"},
            new Beer() { alcohol=3, size=100, name="Piedra Lisa", brand="Colina"}
        }
    }
};

var barList = (from d in bars
            where d.beers.Where(c => c.name == "Stout").Count()>0
            select d).ToList();

foreach (var bar in barList)
{
    Console.WriteLine(bar.Name);
}*/

    // Subquery

    /*var barsData = (from d in bars
                where d.beers.Where(c => c.name == "Stout").Count()>0
                select new BarData(d.Name)
                {
                    beverages = (from c in d.beers
                                    select new Beverage(c.name, c.size)
                                    ).ToList()
                }
                ).ToList(); 

    foreach (var bar in barsData)
    {
        Console.WriteLine(bar.Name);
    }*/



//**************** Exceptions Control

/*try
{
    using (var file = new StreamWriter(@"C:\hola.txt"))
    {
        file.WriteLine("Hi ducks");
    }
} 
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

/*try
{
    var searcherBeer = new SearcherBeer();
    var size = searcherBeer.GetSize("Stoutaa");
    Console.WriteLine(size);
}
catch (BeerNotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I always executed");
}*/



//**************** Delegates

/*var myDelegate = new Delegate();
myDelegate.Main();

class Delegate
{

public delegate void Mostrar(string message);

public void Main()
{
Mostrar mostrar = Show;
Make(mostrar);
}

public static void Make(Mostrar mostrar)
{
    mostrar("I like");
}

public static void Show(string str)
{
    Console.WriteLine("I am a delegate and " + str);
}
}*/



//**************** Func

/*var myFunc = new ClassFunc();
myFunc.Main();

class ClassFunc
{

public void Main()
{
Func<string,int> mostrar = Show;
Make(mostrar);
}

public void Make(Func<string,int> mostrar)
{
    Console.WriteLine(mostrar("I like"));
}

public int Show(string str)
{
    return str.Count();
}
}*/

// Action

/*var myAct = new ClassAction();
myAct.Main();

class ClassAction
{

public void Main()
{
//Action<string,string> mostrar = Show;
//With lambda function. Avoid Show function
Action<string,string> mostrar = (a,b) => Console.WriteLine(a + b);;
Make(mostrar);
}

public void Make(Action<string,string> mostrar)
{
    mostrar("I like", " a lot");
}

public void Show(string str, string str2)
{
    Console.WriteLine(str + str2);
}
}*/



//**************** Predicates

ClassPredicates.Main();

static class ClassPredicates
{
    public static void Main()
    {
    
    /*var numbers = new List<int>() {2, 45, 5, 6, 7, 13, 354, 33, 22};
    var predicate = new Predicate<int>(x => x % 2 == 0);
    Predicate<int> negativePredicate = x => !predicate(x);
    var dividers2 = numbers.FindAll(predicate);
    var dividers2 = numbers.FindAll(negativePredicate);

    dividers2.ForEach(n => {Console.WriteLine(n);});*/    
  
        var beers = new List<Beer>()
        {
            new Beer() { alcohol=7, name="Stout"},
            new Beer() { alcohol=3, name="Piedra Lisa"},
            new Beer() { alcohol=7, name="Pale ale"},
            new Beer() { alcohol=2, name="Pilsen"}
        };

        beers.ShowBeerThatIGetDrunk(x => x.alcohol >= 6);
    }

    static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
    {
        var evilBeers = beers.FindAll(condition);
        evilBeers.ForEach(b => Console.WriteLine(b.name));
    }
}