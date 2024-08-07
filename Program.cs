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

        string opcionMenu = "0";

        do
        {
            MenuPrincipal();
            opcionMenu = Console.ReadLine();

            // Crear 10 personajes si no existe el archivo o la opcion es 1

            switch (opcionMenu)
            {
                case "1":
                    // Elimina el archivo si existe
                    if (PersonajesJson.Existe(archivoPersonajes))
                    {
                        File.Delete(archivoPersonajes);
                    }
                    await CrearPersonajes(idsPersonajes, archivoPersonajes);
                    break;

                case "2":
                    if (PersonajesJson.Existe(archivoPersonajes))
                    {
                        await Jugar(archivoPersonajes, archivoHistorial);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontraron personajes para jugar. (Primero debe CREAR LOS PERSONAJES)\n");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nCargando partida...\n");// En desarrollo
                    break;

                case "4":
                    // Mostrar ganadores
                    if (HistorialJson.Existe(archivoHistorial))
                    {
                        List<Personaje> personajesGanadores = await HistorialJson.LeerGanadores(archivoHistorial);
                        Console.WriteLine("\nHistorial de ganadores:\n");
                        HistorialJson.MostrarGanadores(personajesGanadores);
                    }
                    else
                    {
                        Console.WriteLine("\nTodavia no hay historial de ganadores\n");
                    }
                    break;
                case "5":
                    Console.WriteLine("\nSaliendo del juego...\n");
                    opcionMenu = "5";
                    break;
                default:
                    Console.WriteLine("\nOpcionMenu no valida. Ingrese de nuevo\n");
                    break;
            }

        } while (opcionMenu != "5");
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
        Console.WriteLine("\n1. CREAR PERSONAJES ");
        Console.WriteLine("\n2. NUEVA PARTIDA ");
        Console.WriteLine("\n3. CARGAR PARTIDA ");
        Console.WriteLine("\n4. MOSTRAR HISTORIAL ");
        Console.WriteLine("\n5. SALIR ");
        Console.WriteLine("\nINGRESE:");
    }


    private static async Task Jugar(string archivoPersonajes, string archivoHistorial)
    {
        Personaje ganadorTemp = null;
        string seguirJugando = "1";

        // Leer personajes desde JSON
        List<Personaje> personajesLeidos = await PersonajesJson.LeerPersonajes(archivoPersonajes);

        if (personajesLeidos != null )
        {
            Ascii.PersonajesTitulo();
            PersonajesJson.MostrarNombres(personajesLeidos);
        }
        else
        {
            Console.WriteLine("No se encontraron personajes en el archivo JSON.");
            return;
        }

        Console.WriteLine("\nA continuacion se eligiran dos personajes aleatorios");
        Console.WriteLine("\nPresiona una tecla para seguir...");
        Console.ReadKey();

        do
        {
            // Elegir 2 personajes para la pelea

            Personaje player1, player2, ganador = null;
            player1 = PersonajesJson.ElegirPersonaje(ganadorTemp, personajesLeidos);
            // Guardar salud inicial player 1
            float saludInicial1 = player1.Caracteristicas.Salud;
            player2 = PersonajesJson.ElegirOponente(player1, personajesLeidos);
            // Guardar salud inicial player 2
            float saludInicial2 = player2.Caracteristicas.Salud;

            // Mostrar los 2 personajes
            PersonajesJson.MostrarContrincantes(player1, player2);

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

            // Eliminar perdedor
            if (ganador.Datos.Apodo == player1.Datos.Apodo)
            {
                ganadorTemp = player1;
                // Aumentar salud ganador
                ganadorTemp.Caracteristicas.Salud = Batalla.AumentarSalud(saludInicial1);
                personajesLeidos.Remove(player2);
            }
            else
            {

                ganadorTemp = player2;
                // Aumentar salud ganador
                ganadorTemp.Caracteristicas.Salud = Batalla.AumentarSalud(saludInicial2);
                personajesLeidos.Remove(player1);
            }


            if (personajesLeidos.Count > 1)
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nINGRESE 1 PARA SEGUIR JUGANDO: ");
                Console.WriteLine("\nINGRESE 2 PARA GUARDAR LA PARTIDA: ");
                Console.WriteLine("\nINGRESE 3 PARA SALIR SIN GUARDAR: \n");
                seguirJugando = Console.ReadLine();

            }

            // Console.WriteLine("\nINGRESE 1 PARA JUGAR OTRA VEZ: ");
            // seguir = Console.ReadLine();

        } while (seguirJugando == "1" && personajesLeidos.Count > 1);

        if (seguirJugando == "2")
        {
            // Guardar partida
        }

        if (ganadorTemp != null && personajesLeidos.Count == 1)
        {
            // Guardar ganador en json
            await HistorialJson.GuardarGanador(ganadorTemp, archivoHistorial);
            Console.WriteLine("Ganador guardado en el archivo de historial correctamente.");
        }
    }
}