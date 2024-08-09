﻿using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Programa
{
    public static async Task Main(string[] args)
    {
        // Lista de id de los personajes de la api
        List<int> idsPersonajes = new List<int> { 332, 620, 720, 70, 309, 370, 644, 346, 717, 157, 213, 165 };

        string archivoPersonajes = "characters.json";
        string archivoHistorial = "historial.json";
        string archivoPartida = "partida.json";

        string opcionMenu = "0";
        do
        {
            Ascii.MenuPrincipal();
            opcionMenu = Console.ReadLine();

            // Crear 10 personajes si no existe el archivo o la opcion es 1

            switch (opcionMenu)
            {
                case "1":
                    Console.WriteLine("\nCreando personajes...");
                    // Elimina el archivo si existe
                    await PersonajesFn.VolverACrear(idsPersonajes, archivoPersonajes);
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
                    // Mostrar ganadores
                    await MostrarGanadores(archivoHistorial);
                    break;

                case "5":
                    Console.WriteLine("\nSaliendo del juego...\n");
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

    private static async Task MostrarGanadores(string archivoHistorial)
    {
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
    }

    private static async Task Jugar(string archivoPersonajes, string archivoHistorial, string archivoPartida, bool cargar)
    {
        Personaje ganadorTemp = null;
        string seguirJugando = "1";

        List<Personaje> personajesLeidos = null;

        // Cargar partida guardada
        if (cargar)
        {
            var (ganador, personajes) = PersonajesFn.CargarPartida(archivoPartida);
            ganadorTemp = ganador;
            personajesLeidos = personajes;
            // CargarPartida(archivoPartida);
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

            Personaje player1, player2, ganador = null;
            player1 = PersonajesFn.ElegirPersonaje(ganadorTemp, personajesLeidos);
            // Guardar salud inicial player 1
            float saludInicial1 = PersonajesFn.GetSaludInicial(player1);
            player2 = PersonajesFn.ElegirOponente(player1, personajesLeidos);
            // Guardar salud inicial player 2
            float saludInicial2 = PersonajesFn.GetSaludInicial(player2);

            // Mostrar los 2 personajes
            PersonajesFn.MostrarContrincantes(player1, player2);

            // Batalla
            Ascii.Comienzo();
            Thread.Sleep(1000);

            ganador = Batalla.Pelear(player1, player2);

            PersonajesFn.MostrarGanadorBatalla(ganador);

            // Asignar ganador
            ganadorTemp = PersonajeGanador(personajesLeidos, player1, player2, ganador, saludInicial1, saludInicial2);

            if (personajesLeidos.Count > 1)
            {
                Ascii.MenuSecundario();
                seguirJugando = Console.ReadLine();

                if (seguirJugando == "2")
                {
                    PersonajesFn.GuardarPartida(archivoPartida, ganadorTemp, personajesLeidos);

                }
            }

        } while (seguirJugando == "1" && personajesLeidos.Count > 1);

        if (ganadorTemp != null && personajesLeidos.Count == 1)
        {
            // Guardar ganador en json
            await HistorialJson.GuardarGanador(ganadorTemp, archivoHistorial);
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
            // Aumentar salud ganador
            PersonajesFn.ModificarSalud(ganadorTemp, Batalla.BonusSalud(saludInicial1));
            // ganadorTemp.Caracteristicas.Salud = Batalla.BonusSalud(saludInicial1);
            personajesLeidos.Remove(player2);
        }
        else
        {

            ganadorTemp = player2;
            // Aumentar salud ganador
            PersonajesFn.ModificarSalud(ganadorTemp, Batalla.BonusSalud(saludInicial2));
            // ganadorTemp.Caracteristicas.Salud = Batalla.BonusSalud(saludInicial2);
            personajesLeidos.Remove(player1);
        }

        return ganadorTemp;
    }

}