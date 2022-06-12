using System.Data.SqlClient;

class BeerDB
{
    private string connectionString
        = "server=DESKTOP-A46TG27\\SQLEXPRESS;database=FundamentosCSharpHectorDeLeon;"+
        "User=sa;Password=123456";

    public List<Beer> Get()
    {
        List<Beer> beers = new List<Beer>();
        string query = "select name, brand, alcohol, size " +
        "from beer";

        using(SqlConnection connection = new SqlConnection(connectionString))
        {  
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int size = reader.GetInt32(3);
                string name = reader.GetString(0);
                Beer beer = new Beer(name, size);
                beer.alcohol =reader.GetInt32(2);
                beer.brand = reader.GetString(1);

                beers.Add(beer);
            }

            reader.Close();
            connection.Close();
        }

        return beers;
    }

    public void Add(Beer beer)
    {
        string query = "insert into beer (name, brand, alcohol, size) " +
        "values(@name, @brand, @alcohol, @size)";

        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", beer.name);
            command.Parameters.AddWithValue("@brand", beer.brand);
            command.Parameters.AddWithValue("@alcohol", beer.alcohol);
            command.Parameters.AddWithValue("@size", beer.size);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }


    public void Update(Beer beer, int Id)
    {
        string query = "update beer set name=@name, " +
        "brand=@brand, alcohol=@alcohol, size=@size " +
        "where id=@id";

        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", beer.name);
            command.Parameters.AddWithValue("@brand", beer.brand);
            command.Parameters.AddWithValue("@alcohol", beer.alcohol);
            command.Parameters.AddWithValue("@size", beer.size);
            command.Parameters.AddWithValue("@id", Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }


    public void Delete(int Id)
    {
        string query = "delete from beer " +
        "where id=@id";

        using (var connection = new SqlConnection(connectionString))
        {
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", Id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}