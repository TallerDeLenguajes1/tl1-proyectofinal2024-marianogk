using EspacioPersonaje;

public static class PersonajesFn
{
    public static void MostrarPersonajes(List<Personaje> personajes)
    {
        Console.WriteLine("Personaje:");
        foreach (var pj in personajes)
        {
            MostrarPersonaje(pj);
        }
    }

    public static void MostrarNombres(List<Personaje> personajes)
    {
        Console.WriteLine("+-----------------+---------------------+-----------------+");
        Console.WriteLine("|     Apodo       |  Nombre Completo    |      Tipo       |");
        Console.WriteLine("+-----------------+---------------------+-----------------+");
        foreach (var pj in personajes)
        {
            Console.WriteLine($"| {pj.Datos.Apodo.PadRight(15)} | {pj.Datos.Nombre.PadRight(19)} | {pj.Datos.Tipo.PadRight(15)} |");
        }
        Console.WriteLine("+-----------------+---------------------+-----------------+");
    }

    public static void MostrarPersonaje(Personaje pj)
    {

        Console.WriteLine("\n\n-DATOS-\n");
        Console.WriteLine("Tipo: " + pj.Datos.Tipo);
        Console.WriteLine("Nombre Completo: " + pj.Datos.Nombre);
        Console.WriteLine("Apodo: " + pj.Datos.Apodo);
        Console.WriteLine("Fecha de nacimiento: " + pj.Datos.FechaDeNacimiento);
        Console.WriteLine("Edad: " + pj.Datos.Edad);

        Console.WriteLine("\n-CARACTERISTICAS-\n");
        Console.WriteLine("Velocidad: " + pj.Caracteristicas.Velocidad);
        Console.WriteLine("Destreza: " + pj.Caracteristicas.Destreza);
        Console.WriteLine("Fuerza: " + pj.Caracteristicas.Fuerza);
        Console.WriteLine("Nivel: " + pj.Caracteristicas.Nivel);
        Console.WriteLine("Armadura: " + pj.Caracteristicas.Armadura);
        Console.WriteLine("Salud: " + pj.Caracteristicas.Salud);

    }
    public static void MostrarContrincantes(Personaje player1, Personaje player2)
    {
        Console.WriteLine("\n+-----------------+-----------PERSONAJE 1----------+-----------------+\n");
        MostrarPersonaje(player1);
        Thread.Sleep(2500);
        Console.WriteLine("\n+-----------------+-----------PERSONAJE 2----------+-----------------+\n");
        MostrarPersonaje(player2);
        Thread.Sleep(2500);
    }

    public static Personaje ElegirPersonaje(Personaje ganadorTemp, List<Personaje> personajesLeidos)
    {
        Random randomId = new Random();
        Personaje player1;

        // Si ya hay un ganador, sigue el mismo personaje

        if (ganadorTemp != null)
        {
            player1 = ganadorTemp;
        }
        else
        {
            // Crear un indice aleatorio para el personaje 1
            int idP1 = randomId.Next(0, personajesLeidos.Count);

            player1 = personajesLeidos[idP1];

        }
        return player1;
    }

    public static Personaje ElegirOponente(Personaje player1, List<Personaje> personajesLeidos)
    {
        Random randomId = new Random();
        Personaje player2;

        // Crear una lista de personajes disponibles para la pelea
        List<Personaje> personajesDisponibles = new List<Personaje>(personajesLeidos);
        personajesDisponibles.Remove(player1);

        // Crear un indice aleatorio para el personaje 2
        int idP2 = randomId.Next(0, personajesDisponibles.Count);
        player2 = personajesDisponibles[idP2];
        return player2;
    }
    public static float GetSaludInicial(Personaje pj)
    {
        return pj.Caracteristicas.Salud;
    }

    public static void ModificarSalud(Personaje personaje, float nuevaSalud)
    {
        // Asegúrate de que la nueva salud esté en el rango válido
        if (nuevaSalud < 0)
        {
            nuevaSalud = 0;
        }
        // Modifica la propiedad Salud del personaje
        personaje.Caracteristicas.Salud = nuevaSalud;
    }

    public static async Task CrearPersonajes(List<int> idsPersonajes, string archivoPersonajes)
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
            }
            else
            {
                Console.WriteLine("\nNo se pudo obtener el personaje de la api");
            }
        }

        // Guardar personajes en JSON
        await PersonajesJson.GuardarPersonajes(personajes, archivoPersonajes);
    }

    public static void GuardarPartida(string archivoPartida, Personaje ganadorTemp, List<Personaje> personajesLeidos)
    {
        personajesLeidos.Remove(ganadorTemp); // Eliminar ganador para que no se repita
        PartidaJson partida = new PartidaJson(ganadorTemp, personajesLeidos);

        try // Crear partida para guardarla
        {
            PartidaJson.GuardarPartida(partida, archivoPartida);
            Console.WriteLine("\nPartida guardada correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar la partida: {ex.Message}");
        }
    }

}