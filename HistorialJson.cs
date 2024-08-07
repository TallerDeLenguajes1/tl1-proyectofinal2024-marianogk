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
            List<Personaje> personajes;

            if (Existe(nombreArchivo))
            {
                // Leer los ganadores si ya existe el archivo
                personajes = await LeerGanadores(nombreArchivo);
            }
            else
            {
                // Crear una nueva lista si el archivo no existe
                personajes = new List<Personaje>();
            }

            // Agregar el nuevo ganador a la lista
            personajes.Add(personaje);

            // Guardar la lista en el archivo
            string jsonString = JsonSerializer.Serialize(personajes, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(nombreArchivo, jsonString);

            Console.WriteLine("Ganador guardado en el archivo de historial correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer el personaje ganador desde un archivo JSON
    public static async Task<List<Personaje>> LeerGanadores(string nombreArchivo)
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
            Console.WriteLine("Error al leer el archivo: " + ex.Message);
            return new List<Personaje>();
        }
    }

    // Metodo para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }

    public static void MostrarGanadores(List<Personaje> personajes)
    {
        Console.WriteLine("|     Apodo       |  Nombre Completo    |      Tipo       |");
        foreach (var pj in personajes)
        {
            
            Console.WriteLine($"| {pj.Datos.Apodo.PadRight(15)} | {pj.Datos.Nombre.PadRight(19)} | {pj.Datos.Tipo.PadRight(15)} |");
        }
    }
}