using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

// Crear un indice aleatorio para la api del personaje
Random randomId = new Random();
int idP;
int[] idsPersonajes = [332,659,620,623,579,165,344,720,107,69,309,370,644,149,346,263,717,655];
int i = randomId.Next(0,17);
idP = idsPersonajes[i];


Root salida = await GetPersonaje(idP);

foreach (var item in salida.results)
{
    Console.WriteLine(item.name + "\n");
}

static async Task<Root> GetPersonaje(int idP)
{
    var url = "https://www.superheroapi.com/api.php/"+idP+"";

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
