using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class PersonajesJson
{
    // Metodo para guardar una lista de personajes en un archivo JSON
    public static async Task GuardarPersonajes(List<Personaje> personajes, string nombreArchivo)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(personajes, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(nombreArchivo, jsonString);
            Console.WriteLine("\nPersonajes guardados en " + nombreArchivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer una lista de personajes desde un archivo JSON
    public static async Task<List<Personaje>> LeerPersonajes(string nombreArchivo)
    {
        try
        {
            if (Existe(nombreArchivo))
            {
                string jsonString = await File.ReadAllTextAsync(nombreArchivo);
                List<Personaje> personajes = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
                return personajes;
            }
            else
            {
                return new List<Personaje>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al leer el archivo: " + ex.Message);
            return new List<Personaje>();
        }
    }

    // Metodo para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }

}