//Example - Generics

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;

public class SendRequest<T>
{

    private HttpClient _client = new HttpClient();

    public async Task<T> Send(T model)
    {
        string url = "http://jsonplaceholder.typicode.com/posts";
        
        //Enable case-insensitive property name matching with System.Text.Json
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var data = JsonSerializer.Serialize<T>(model, options);

        HttpContent content =
            new StringContent(data, System.Text.Encoding.UTF8, "application/json");

        var httpResponse = await _client.PostAsync(url, content);

        if (httpResponse.IsSuccessStatusCode)
        {
            var result = await httpResponse.Content.ReadAsStringAsync();

            var postResult = JsonSerializer.Deserialize<T>(result, options);

            return postResult;
        }

        return default(T);

    }
}