using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class PartidaJson
{
    // Propiedades privadas con getter y setter privados
    [JsonInclude] // Permite que estas propiedades sean serializadas y deserializadas a través de JSON
    public Personaje Jugador { get; private set; }

    [JsonInclude] // Permite que estas propiedades sean serializadas y deserializadas a través de JSON
    public List<Personaje> Oponentes { get; private set; }

    // Método para guardar una partida en un archivo JSON
    [JsonConstructor]
    public PartidaJson(Personaje jugador, List<Personaje> oponentes)
    {
        Jugador = jugador;
        Oponentes = oponentes;
    }

    // Metodo para guardar una lista de personajes en un archivo JSON
    public static void GuardarPartida(PartidaJson partida, string archivoPartida, Personaje ganadorTemporal)
    {
        try
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            using (var archivo = new FileStream(archivoPartida, FileMode.Create))
            {
                using (var strWriter = new StreamWriter(archivo))
                {
                    string json = JsonSerializer.Serialize(partida, opciones);
                    strWriter.WriteLine(json);
                    strWriter.Flush();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al guardar el archivo: " + ex.Message);
        }
    }

    // Metodo para leer partida desde un archivo JSON
    public static PartidaJson CargarPartida(string archivoPartida)
    {
        PartidaJson partida = null;
        try
        {
            if (Existe(archivoPartida))
            {
                using (var archivoOpen = new FileStream(archivoPartida, FileMode.Open))
                {
                    using (var strReader = new StreamReader(archivoOpen))
                    {
                        string json = strReader.ReadToEnd();
                        partida = JsonSerializer.Deserialize<PartidaJson>(json);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nError al leer el archivo: " + ex.Message);

        }
        return partida;
    }

    // Metodo para verificar si un archivo existe y tiene datos
    public static bool Existe(string nombreArchivo)
    {
        return File.Exists(nombreArchivo) && new FileInfo(nombreArchivo).Length > 0;
    }

    internal static PartidaJson CargarPartida(object archivoPartida)
    {
        throw new NotImplementedException();
    }
}