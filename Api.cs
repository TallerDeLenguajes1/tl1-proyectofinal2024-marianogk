using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Api
{
    public static async Task<Root> GetPersonaje(int idP)
    {
        var url = $"https://www.superheroapi.com/api.php/05d397d99a857530dc23cf8bd992412d/{idP}";

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
}

// string fileJson = JsonSerializer.Serialize(salida);

// string ruta = @"C:\taller1\tl1-proyectofinal2024-marianogk\player.json";

// if (File.Exists(ruta))
// {
//     Console.WriteLine("El archivo ya existe");

// }
// else
// {
//     File.WriteAllText(ruta, fileJson);
//     Console.WriteLine("Datos guardados en " + ruta);
// }
