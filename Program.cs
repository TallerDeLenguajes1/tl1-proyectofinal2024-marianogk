using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Programa
{

    public static async Task Main(string[] args)
    {
        // Lista de id de los personajes de la api
        List<int> idsPersonajes = new List<int> { 332, 659, 620, 623, 579, 165, 344, 720, 107, 69, 309 };

        string archivoPersonajes = @"C:\taller1\tl1-proyectofinal2024-marianogk\characters.json";

        // Crear 10 personajes si no existe el archivo

        if (!File.Exists(archivoPersonajes))
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = await PersonajesJson.LeerPersonajes(archivoPersonajes);
            int p = 0;
            while (personajes.Count < 11)
            {
                
                int id = idsPersonajes[p];
                p++;

                Root salida = await Api.GetPersonaje(id); // Obtener el personaje desde la API                

                if (salida != null)
                {

                    Personaje personaje = fabrica.CrearPersonajeAleatorio(salida);
                    personajes.Add(personaje);

                    // Guardar personajes en JSON

                    await PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);
                    Console.WriteLine("Personaje guardado en el archivo JSON correctamente: " + archivoPersonajes);
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
            List<Personaje> personajesLeidos = await PersonajesJson.LeerPersonajes(archivoPersonajes);
            if (personajesLeidos != null)
            {
                PersonajesJson.MostrarNombres(personajesLeidos);
            }
            else
            {
                Console.WriteLine("No se encontraron personajes en el archivo JSON.");
            }



            // Elegir 2 personajes para la pelea

            // Crear un indice aleatorio para los 2 personajes
            Random randomId = new Random();

            int idP1 = randomId.Next(0, idsPersonajes.Count);
            int idP2 = randomId.Next(0, idsPersonajes.Count);

            List<Personaje> personajesElegidos = new List<Personaje>();

            Personaje player1, player2;

            player1 = personajesLeidos[idP1];

            player2 = personajesLeidos[idP2];

            personajesElegidos.Add(player1);
            personajesElegidos.Add(player2);

            PersonajesJson.MostrarPersonajes(personajesElegidos);

            // Pelear

            Personaje ganador;

            ganador = Batalla.Pelear(player1, player2);

            // Mostrar y guardar ganador

            Console.WriteLine("El ganador es: " + ganador);

            string archivoHistorial = @"C:\taller1\tl1-proyectofinal2024-marianogk\historial.json";

            await HistorialJson.GuardarGanador(ganador, archivoHistorial);
            Console.WriteLine("Ganador guardado en el archivo de historial correctamente.");
        }



    }

}