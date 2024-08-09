using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class PartidaJson
{
    public Personaje Jugador { get; private set; }
    public List<Personaje> Oponentes { get; private set; }
    public PartidaJson(Personaje jugador, List<Personaje> oponentes)
    {
        Jugador = jugador;
        Oponentes = oponentes;
    }

    // Metodo para guardar la lista de personajes de la partida en un archivo JSON
    public static void GuardarPartida(PartidaJson partida, string archivoPartida)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(partida, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivoPartida, jsonString);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer partida desde un archivo JSON
    public static PartidaJson CargarPartida(string archivoPartida)
    {
        // PartidaJson partida = null;
        if (!Existe(archivoPartida))
        {
            Console.WriteLine("El archivo no existe.");
            return null;
        }
        try
        {
            // Leer el contenido del archivo
            string json = File.ReadAllText(archivoPartida);

            // Deserializar el contenido JSON en un objeto PartidaJson
            PartidaJson partida = JsonSerializer.Deserialize<PartidaJson>(json);

            return partida;
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al leer el archivo: " + ex.Message);
            return null;
        }
    }

    // Metodo para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }

}