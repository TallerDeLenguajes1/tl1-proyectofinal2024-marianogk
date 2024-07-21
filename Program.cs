using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Programa
{
    public static async Task Main(string[] args)
    {
        // Lista de id de los personajes de la api
        List<int> idsPersonajes = new List<int> { 332, 620, 720, 70, 309, 370, 644, 346, 717, 157, 213, 165 };

        string archivoPersonajes = @"C:\taller1\tl1-proyectofinal2024-marianogk\characters.json";

        // Crear 10 personajes si no existe el archivo

        if (!File.Exists(archivoPersonajes))
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = await PersonajesJson.LeerPersonajes(archivoPersonajes);
            int p = 0;
            while (personajes.Count < 12)
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
            string seguir="1";

            do
            {
                // Leer personajes desde JSON
                List<Personaje> personajesLeidos = await PersonajesJson.LeerPersonajes(archivoPersonajes);
                if (personajesLeidos != null)
                {
                    Ascii.PersonajesTitulo();
                    PersonajesJson.MostrarNombres(personajesLeidos);
                }
                else
                {
                    Console.WriteLine("No se encontraron personajes en el archivo JSON.");
                }

                Console.WriteLine("\nA continuacion se eligiran dos personajes aleatorios");
                Console.WriteLine("\nPresiona una tecla para seguir...");
                Console.ReadKey();

                // Elegir 2 personajes para la pelea

                // Crear un indice aleatorio para los 2 personajes
                Random randomId = new Random();

                int idP1 = randomId.Next(0, idsPersonajes.Count);

                // Borrar el id del personaje 1, para que no se repita
                idsPersonajes.RemoveAt(idP1);

                int idP2 = randomId.Next(0, idsPersonajes.Count);

                List<Personaje> personajesElegidos = new List<Personaje>();

                Personaje player1, player2;

                player1 = personajesLeidos[idP1];

                player2 = personajesLeidos[idP2];

                Console.WriteLine("\n+-----------------+-----------PERSONAJE 1----------+-----------------+\n");
                PersonajesJson.MostrarPersonaje(player1);
                Console.WriteLine("\n+-----------------+-----------PERSONAJE 2----------+-----------------+\n");
                PersonajesJson.MostrarPersonaje(player2);

                // Batalla

                Ascii.Comienzo();

                Personaje ganador = Batalla.Pelear(player1, player2);

                // Mostrar y guardar ganador

                Thread.Sleep(1000);
                string texto = "\n\nEL GANADOR ES... \n";
                Ascii.ImprimirConDelay(texto, 100);
                Thread.Sleep(1000);
                Ascii.MostrarGanador(ganador);
                Thread.Sleep(1500);
                PersonajesJson.MostrarPersonaje(ganador);

                string archivoHistorial = @"C:\taller1\tl1-proyectofinal2024-marianogk\historial.json";

                await HistorialJson.GuardarGanador(ganador, archivoHistorial);
                Console.WriteLine("Ganador guardado en el archivo de historial correctamente.");

                Thread.Sleep(1000);
                Console.WriteLine("\nINGRESE 1 PARA JUGAR OTRA VEZ: ");
                seguir = Console.ReadLine();

            } while (seguir == "1");

            //Fin del juego
            Ascii.Fin();
        };

    }

}