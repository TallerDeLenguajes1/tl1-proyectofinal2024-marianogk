using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Programa
{
    public static async Task Main(string[] args)
    {
        string nombreArchivo = @"C:\taller1\tl1-proyectofinal2024-marianogk\characters.json";

        if (!File.Exists(nombreArchivo))
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = await PersonajesJson.LeerPersonajes(nombreArchivo);
            int p = 0;
            while (personajes.Count < 11)
            {
                List<int> idsPersonajes = new List<int> { 332, 659, 620, 623, 579, 165, 344, 720, 107, 69, 309};

                int idP = idsPersonajes[p];
                p++;

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