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
            Console.WriteLine("Datos guardados en " + nombreArchivo);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer una lista de personajes desde un archivo JSON
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

    public static void MostrarPersonajes(List<Personaje> personajes)
    {
        Console.WriteLine("Personaje:");
        foreach (var pj in personajes)
        {
            MostrarPersonaje(pj);
        }
    }

    public static void MostrarNombres(List<Personaje> personajes)
    {
        foreach (var pj in personajes)
        {
            Console.WriteLine("-");
            Console.WriteLine("Tipo: " + pj.Datos.Tipo);
            Console.WriteLine("Nombre Completo: " + pj.Datos.Nombre);
            Console.WriteLine("Apodo: " + pj.Datos.Apodo);
        }
    }

    public static void MostrarPersonaje(Personaje pj)
    {

        Console.WriteLine("-DATOS-");
        Console.WriteLine("Tipo: " + pj.Datos.Tipo);
        Console.WriteLine("Nombre Completo: " + pj.Datos.Nombre);
        Console.WriteLine("Apodo: " + pj.Datos.Apodo);
        Console.WriteLine("Fecha de nacimiento: " + pj.Datos.FechaDeNacimiento);
        Console.WriteLine("Edad: " + pj.Datos.Edad);

        Console.WriteLine("-CARACTERISTICAS-");
        Console.WriteLine("Velocidad: " + pj.Caracteristicas.Velocidad);
        Console.WriteLine("Destreza: " + pj.Caracteristicas.Destreza);
        Console.WriteLine("Fuerza: " + pj.Caracteristicas.Fuerza);
        Console.WriteLine("Nivel: " + pj.Caracteristicas.Nivel);
        Console.WriteLine("Armadura: " + pj.Caracteristicas.Armadura);
        Console.WriteLine("Salud: " + pj.Caracteristicas.Salud);

    }
}