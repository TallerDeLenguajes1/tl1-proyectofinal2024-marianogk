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
        string archivoHistorial = @"C:\taller1\tl1-proyectofinal2024-marianogk\historial.json";

        string opcion = "0";

        MenuPrincipal();
        opcion = Console.ReadLine();

        // Crear 10 personajes si no existe el archivo o la opcion es 1
        if (opcion == "1" || !PersonajesJson.Existe(archivoPersonajes))
        {
            // Elimina el archivo si existe
            if (PersonajesJson.Existe(archivoPersonajes))
            {
                File.Delete(archivoPersonajes);
            }
            else
            {
                await CrearPersonajes(idsPersonajes, archivoPersonajes);
            }
        }
        if (PersonajesJson.Existe(archivoPersonajes) && opcion != "3")
        {
            Personaje ganadorTemp = null;
            string seguir = "1";

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

            do
            {
                // Elegir 2 personajes para la pelea
                Personaje player1, player2, ganador = null;

                Random randomId = new Random();

                // Si ya hay un ganador, sigue el mismo personaje

                if (ganadorTemp != null)
                {
                    player1 = ganadorTemp;
                }
                else
                {
                    // Crear un indice aleatorio para el personaje 1
                    int idP1 = randomId.Next(0, idsPersonajes.Count);

                    player1 = personajesLeidos[idP1];

                }

                // Guardar salud inicial
                float saludInicial = player1.Caracteristicas.Salud;

                // Crear una lista de personajes disponibles para la pelea
                List<Personaje> personajesDisponibles = new List<Personaje>(personajesLeidos);
                personajesDisponibles.Remove(player1);

                // Crear un indice aleatorio para el personaje 2
                int idP2 = randomId.Next(0, personajesDisponibles.Count);
                player2 = personajesDisponibles[idP2];

                Console.WriteLine("\n+-----------------+-----------PERSONAJE 1----------+-----------------+\n");
                PersonajesJson.MostrarPersonaje(player1);
                Thread.Sleep(2500);
                Console.WriteLine("\n+-----------------+-----------PERSONAJE 2----------+-----------------+\n");
                PersonajesJson.MostrarPersonaje(player2);
                Thread.Sleep(2500);

                // Batalla
                Ascii.Comienzo();
                Thread.Sleep(1000);

                ganador = Batalla.Pelear(player1, player2);


                // Mostrar y guardar ganador
                Thread.Sleep(1000);
                string texto = "\n\nEL GANADOR ES... \n";
                Ascii.ImprimirConDelay(texto, 100);
                Thread.Sleep(1000);
                Ascii.MostrarGanador(ganador);
                Thread.Sleep(1500);
                PersonajesJson.MostrarPersonaje(ganador);

                // Aumentar salud ganador
                ganador.Caracteristicas.Salud = Batalla.AumentarSalud(saludInicial);

                // Eliminar perdedor
                if (ganador.Datos.Apodo == player1.Datos.Apodo)
                {
                    ganadorTemp = player1;
                    personajesLeidos.Remove(player2);
                }
                else
                {
                    ganadorTemp = player2;
                    personajesLeidos.Remove(player1);
                }


                if (personajesLeidos.Count > 1)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("\nINGRESE 1 PARA SEGUIR JUGANDO: ");
                    seguir = Console.ReadLine();
                }

                // Console.WriteLine("\nINGRESE 1 PARA JUGAR OTRA VEZ: ");
                // seguir = Console.ReadLine();

            } while (seguir == "1" && personajesLeidos.Count > 1);

            if (ganadorTemp != null)
            {
                // Guardar ganador en json
                await HistorialJson.GuardarGanador(ganadorTemp, archivoHistorial);
                Console.WriteLine("Ganador guardado en el archivo de historial correctamente.");
            }

            //Fin del juego
            Ascii.Fin();
        }
        else
        {
            // Mostrar ganadores
            if (HistorialJson.Existe(archivoHistorial))
            {
                List<Personaje> personajesGanadores = await HistorialJson.LeerGanadores(archivoHistorial);
                Console.WriteLine("\nHistorial de ganadores:\n");
                HistorialJson.MostrarGanadores(personajesGanadores);
            }
            //Fin del juego
            Ascii.Fin();
        }

        static async Task CrearPersonajes(List<int> idsPersonajes, string archivoPersonajes)
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = await PersonajesJson.LeerPersonajes(archivoPersonajes);
            int p = 0; // indice para la lista de los indices de personajes
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

        static void MenuPrincipal()
        {
            Console.WriteLine("\n1. CREAR PERSONAJES \n");
            Console.WriteLine("\n2. JUGAR \n");
            Console.WriteLine("\n3. SALIR \n");
            Console.WriteLine("\nINGRESE:");
        }
    }

}