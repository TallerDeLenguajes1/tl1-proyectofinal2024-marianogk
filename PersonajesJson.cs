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
        Console.WriteLine("+-----------------+---------------------+-----------------+");
        Console.WriteLine("|     Apodo       |  Nombre Completo    |      Tipo       |");
        Console.WriteLine("+-----------------+---------------------+-----------------+");
        foreach (var pj in personajes)
        {
            Console.WriteLine($"| {pj.Datos.Apodo.PadRight(15)} | {pj.Datos.Nombre.PadRight(19)} | {pj.Datos.Tipo.PadRight(15)} |");
        }
        Console.WriteLine("+-----------------+---------------------+-----------------+");
    }

    public static void MostrarPersonaje(Personaje pj)
    {

        Console.WriteLine("\n\n-DATOS-\n");
        Console.WriteLine("Tipo: " + pj.Datos.Tipo);
        Console.WriteLine("Nombre Completo: " + pj.Datos.Nombre);
        Console.WriteLine("Apodo: " + pj.Datos.Apodo);
        Console.WriteLine("Fecha de nacimiento: " + pj.Datos.FechaDeNacimiento);
        Console.WriteLine("Edad: " + pj.Datos.Edad);

        Console.WriteLine("\n-CARACTERISTICAS-\n");
        Console.WriteLine("Velocidad: " + pj.Caracteristicas.Velocidad);
        Console.WriteLine("Destreza: " + pj.Caracteristicas.Destreza);
        Console.WriteLine("Fuerza: " + pj.Caracteristicas.Fuerza);
        Console.WriteLine("Nivel: " + pj.Caracteristicas.Nivel);
        Console.WriteLine("Armadura: " + pj.Caracteristicas.Armadura);
        Console.WriteLine("Salud: " + pj.Caracteristicas.Salud);

    }
    public static void MostrarContrincantes(Personaje player1, Personaje player2)
    {
        Console.WriteLine("\n+-----------------+-----------PERSONAJE 1----------+-----------------+\n");
        MostrarPersonaje(player1);
        Thread.Sleep(2500);
        Console.WriteLine("\n+-----------------+-----------PERSONAJE 2----------+-----------------+\n");
        MostrarPersonaje(player2);
        Thread.Sleep(2500);
    }

        public static Personaje ElegirPersonaje(Personaje ganadorTemp, List<Personaje> personajesLeidos)
    {
        Random randomId = new Random();
        Personaje player1;

        // Si ya hay un ganador, sigue el mismo personaje

        if (ganadorTemp != null)
        {
            player1 = ganadorTemp;
        }
        else
        {
            // Crear un indice aleatorio para el personaje 1
            int idP1 = randomId.Next(0, personajesLeidos.Count);

            player1 = personajesLeidos[idP1];

        }
        return player1;
    }

    public static Personaje ElegirOponente(Personaje player1, List<Personaje> personajesLeidos)
    {
        Random randomId = new Random();
        Personaje player2;

        // Crear una lista de personajes disponibles para la pelea
        List<Personaje> personajesDisponibles = new List<Personaje>(personajesLeidos);
        personajesDisponibles.Remove(player1);

        // Crear un indice aleatorio para el personaje 2
        int idP2 = randomId.Next(0, personajesDisponibles.Count);
        player2 = personajesDisponibles[idP2];
        return player2;
    }
}