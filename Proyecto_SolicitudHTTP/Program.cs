using Proyecto_SolicitudHTTP;
using System.Net.Http.Headers;
using System.Text.Json;

HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client);

/* Si se utiliza el método que devuelve la colección de repositorios:
List<Repository> repositories = await ProcessRepositoriesAsync2(client);

foreach (var repo in repositories)
    Console.Write(repo.Name);
*/

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    // De la siguiente forma se verá muy feo:
    // var json = await client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
    // Console.Write(json);

    // Deserializando el JSON:
    await using Stream stream = await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
    var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
    
    foreach (var repo in repositories ?? Enumerable.Empty<Repository>())
        // Console.Write(repo.name + "\n"); Si se usa el primer método para declarar la clase Repository
        Console.Write(repo.Name);   // Si se usa el segundo
        
}

// Para que el método devuelva una lista de repositorios:
static async Task<List<Repository>> ProcessRepositoriesAsync2(HttpClient client)
{
    await using Stream stream = await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
    var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);

    return repositories ?? new();
}