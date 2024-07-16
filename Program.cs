using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Programa
{
    public static async Task Main(string[] args)
    {
        string nombreArchivo = @"C:\taller1\tl1-proyectofinal2024-marianogk\players.json";

        if (!File.Exists(nombreArchivo))
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = await PersonajesJson.LeerPersonajes(nombreArchivo);
            while (personajes.Count < 11)
            {
                // Crear un indice aleatorio para la api del personaje
                Random randomId = new Random();
                int[] idsPersonajes = { 332, 659, 620, 623, 579, 165, 344, 720, 107, 69, 309, 370, 644, 149, 346, 263, 717, 655 };
                int idP = idsPersonajes[randomId.Next(0, idsPersonajes.Length)];

                Root salida = await Api.GetPersonaje(idP); // Obtener el personaje desde la API

                if (salida != null)
                {

                    Personaje personaje = fabrica.CrearPersonajeAleatorio(salida);
                    personajes.Add(personaje);

                    // Guardar personajes en JSON

                    await PersonajesJson.GuardarPersonajes(personajes, nombreArchivo);
                    Console.WriteLine("Personaje guardado en el archivo JSON correctamente: " + nombreArchivo);
                }
                else
                {
                    Console.WriteLine("No se pudo obtener el personaje de la api");
                }
            }

        }
        else
        {
            // Leer personajes desde JSON
            List<Personaje> personajesLeidos = await PersonajesJson.LeerPersonajes(nombreArchivo);
            if (personajesLeidos != null)
            {
                PersonajesJson.MostrarNombres(personajesLeidos);
            }
            else
            {
                Console.WriteLine("No se encontraron personajes en el archivo JSON.");
            }
        }
    }

}