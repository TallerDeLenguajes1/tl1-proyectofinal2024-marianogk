using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class PersonajesJson
{
    // Método para guardar una lista de personajes en un archivo JSON
    public static async Task GuardarPersonajes(List<Personaje> personajes, string nombreArchivo)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(personajes, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(nombreArchivo, jsonString);
            Console.WriteLine("Datos guardados en " + nombreArchivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el archivo: " + ex.Message);
        }
    }

    // Método para leer una lista de personajes desde un archivo JSON
    public static async Task<List<Personaje>> LeerPersonajes(string nombreArchivo)
    {
        try
        {
            if (File.Exists(nombreArchivo))
            {
                string jsonString = await File.ReadAllTextAsync(nombreArchivo);
                List<Personaje> personajes = JsonSerializer.Deserialize<List<Personaje>>(jsonString);
                return personajes;
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
            return null;
        }
    }

    // Método para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }
}