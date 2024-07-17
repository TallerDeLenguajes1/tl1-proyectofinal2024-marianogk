using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class HistorialJson
{
    // Metodo para guardar el personaje ganador en un archivo JSON
    public static async Task GuardarGanador(Personaje personaje, string nombreArchivo)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(personaje.Datos, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(nombreArchivo, jsonString);
            Console.WriteLine("Datos guardados en " + nombreArchivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer el personaje ganador desde un archivo JSON
    public static async Task<List<Personaje>> LeerGanador(string nombreArchivo)
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
                return new List<Personaje>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
            return new List<Personaje>();
        }
    }

    // Metodo para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }
}