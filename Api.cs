using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

Root salida = await GetPersonaje();


foreach (var item in salida.results)
{
    Console.WriteLine(item.name + "\n");
}

static async Task<Root> GetPersonaje()
{
    var url = "https://www.superheroapi.com/api.php/05d397d99a857530dc23cf8bd992412d/search/hulk";

    try
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        Root personaje = JsonSerializer.Deserialize<Root>(responseBody);
        return personaje;
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("Problemas de acceso a la API");
        Console.WriteLine($"Error al realizar la solicitud HTTP: {e.Message}");
        return null;
    }
    catch (JsonException e)
    {
        Console.WriteLine($"Error de deserialización JSON: {e.Message}");
        return null;
    }
}

// string fileJson = JsonSerializer.Serialize(salida);

// string ruta = @"C:\taller1\tl1-tp9-2024-marianogk\euro-lastmatch.json";

// if (File.Exists(ruta))
// {
//     Console.WriteLine("El archivo ya existe");

// }
// else
// {
//     File.WriteAllText(ruta, fileJson);
//     Console.WriteLine("Datos guardados en " + ruta);
// }
