using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;
public class Programa
{
    public static async Task Main(string[] args)
    {
        // Lista de id de los personajes de la api
        List<int> idsPersonajes = [332, 620, 720, 70, 309, 370, 644, 346, 717, 157, 213, 165];

        string archivoPersonajes = "characters.json";
        string archivoHistorial = "historial.json";
        string archivoPartida = "partida.json";
        string opcionMenu;
        do
        {
            Ascii.JuegoTitulo();
            Ascii.MenuPrincipal();
            opcionMenu = Console.ReadLine();

            switch (opcionMenu)
            {
                case "1":
                    Console.WriteLine("\nCreando personajes...");
                    // Elimina el archivo si existe
                    await PersonajesFn.ActualizarPersonajes(idsPersonajes, archivoPersonajes);
                    break;

                case "2":
                    if (PersonajesJson.Existe(archivoPersonajes))
                    {
                        await Jugar(archivoPersonajes, archivoHistorial, archivoPartida, false);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontraron personajes para jugar. (Primero debe CREAR LOS PERSONAJES)\n");
                    }
                    break;

                case "3":
                    if (PartidaJson.Existe(archivoPartida))
                    {
                        await Jugar(archivoPersonajes, archivoHistorial, archivoPartida, true);
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontró ninguna partida guardada.\n");
                    }
                    break;

                case "4":
                    // Mostrar historial de ganadores
                    await PersonajesFn.MostrarHistorial(archivoHistorial);
                    break;

                case "5":
                    Console.WriteLine("\nSaliendo del juego...\n");
                    Thread.Sleep(1000);
                    opcionMenu = "5";
                    break;

                default:
                    Console.WriteLine("\nOpcion no valida. Ingrese de nuevo\n");
                    break;
            }

        } while (opcionMenu != "5");
        //Fin del juego
        Ascii.Fin();
    }

    //------------------------------Funciones---------------------------
    private static async Task Jugar(string archivoPersonajes, string archivoHistorial, string archivoPartida, bool cargar)
    {
        Personaje ganadorTemp = null;
        string seguirJugando = "1";
        string seguirViendo = "1";
        bool gano;
        List<Personaje> personajesLeidos;

        // Cargar partida guardada
        if (cargar)
        {
            var (ganador, personajes) = PersonajesFn.CargarPartida(archivoPartida);
            ganadorTemp = ganador;
            personajesLeidos = personajes;
        }
        else
        {

            // Leer personajes desde JSON
            personajesLeidos = await PersonajesJson.LeerPersonajes(archivoPersonajes);

            if (personajesLeidos != null)
            {
                Ascii.PersonajesTitulo();
                PersonajesFn.MostrarNombres(personajesLeidos);
            }
            else
            {
                Console.WriteLine("No se encontraron personajes en el archivo JSON.");
                return;
            }

            Console.WriteLine("\nA continuacion se eligiran dos personajes aleatorios");
            Console.WriteLine("\nPresione una tecla para seguir...");
            Console.ReadKey();
        }
        do
        {
            // Elegir 2 personajes para la pelea

            Personaje player1, player2;
            player1 = PersonajesFn.ElegirPersonaje(ganadorTemp, personajesLeidos);

            float saludInicial1 = PersonajesFn.GetSaludInicial(player1); // Guardar salud inicial player 1
            player2 = PersonajesFn.ElegirOponente(player1, personajesLeidos);

            float saludInicial2 = PersonajesFn.GetSaludInicial(player2); // Guardar salud inicial player 2

            // Mostrar los 2 personajes
            PersonajesFn.MostrarContrincantes(player1, player2);

            // Mostrar lugar aleatorio entre los 2 personajes
            Console.WriteLine("\n*--LUGAR DE LA BATALLA: " + Batalla.LugarBatalla(player1, player2) + " --*\n");

            // Batalla
            Thread.Sleep(2000);
            Ascii.Comienzo();
            Thread.Sleep(1000);

            Personaje ganador = Batalla.Pelear(player1, player2);

            PersonajesFn.MostrarGanadorBatalla(ganador);

            gano = PersonajesFn.CompararNombres(player1, ganador); // devuelve true si ganó

            ganadorTemp = PersonajeGanador(personajesLeidos, player1, player2, ganador, saludInicial1, saludInicial2); // Asignar ganador

            if (gano)
            {

                if (personajesLeidos.Count > 1)
                {
                    Ascii.MenuSecundario();
                    seguirJugando = Console.ReadLine();

                    if (seguirJugando == "2")
                    {
                        PersonajesFn.GuardarPartida(archivoPartida, ganadorTemp, personajesLeidos);

                    }
                }
            }
            else
            {
                Thread.Sleep(2000);
                Ascii.Perdiste();
                Console.WriteLine("\nSeguir viendo:   1.SI 2.NO");
                seguirViendo = Console.ReadLine();
            }
        } while (seguirJugando == "1" && personajesLeidos.Count > 1 && seguirViendo != "2");

        if (ganadorTemp != null && personajesLeidos.Count == 1 && gano)
        {
            Thread.Sleep(1500);
            Ascii.Felicidades();
            Ascii.Ganaste();

            await HistorialJson.GuardarGanador(ganadorTemp, archivoHistorial); // Guardar ganador en json
            Thread.Sleep(2000);
        }

    }

    // Determina si gano el personaje 1 o 2, le asigna la salud al ganador, y elimina el perdedor de la lista
    public static Personaje PersonajeGanador(List<Personaje> personajesLeidos, Personaje player1, Personaje player2, Personaje ganador, float saludInicial1, float saludInicial2)
    {
        Personaje ganadorTemp;
        if (PersonajesFn.CompararNombres(player1, ganador))
        {
            ganadorTemp = player1;

            PersonajesFn.ModificarSalud(ganadorTemp, Batalla.BonusSalud(saludInicial1)); // Aumentar salud ganador
            personajesLeidos.Remove(player2);
        }
        else
        {
            ganadorTemp = player2;

            PersonajesFn.ModificarSalud(ganadorTemp, Batalla.BonusSalud(saludInicial2)); // Aumentar salud ganador
            personajesLeidos.Remove(player1);
        }

        return ganadorTemp;
    }
}