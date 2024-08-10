using EspacioPersonaje;

public class Batalla
{
    // Destreza * Fuerza * Nivel (del personaje que ataca)
    public static int Ataque(Personaje p)
    {
        return p.Caracteristicas.Destreza * p.Caracteristicas.Fuerza * p.Caracteristicas.Nivel;
    }

    // Valor aleatorio entre 1 y 100.
    public static int Efectividad()
    {
        Random i = new Random();
        return i.Next(1, 101);
    }

    // Armadura * Velocidad (del personaje que defiende)
    public static float Defensa(Personaje p)
    {
        return p.Caracteristicas.Armadura * p.Caracteristicas.Velocidad;

    }

    // Daño provocado = (Ataque * Efectividad) - Defensa) / Constante de Ajuste
    public static float Danio(Personaje p1, Personaje p2)
    {
        return (Math.Max(0, (Ataque(p1) * Efectividad() - Defensa(p2)) / 500));
    }

    // Combate de los 2 personajes
    public static Personaje Pelear(Personaje p1, Personaje p2)
    {
        string saltar = "1";

        Console.WriteLine("\nIngrese 0 para saltar la pelea");
        Console.WriteLine("\nIngrese 1 para COMENZAR");
        saltar = Console.ReadLine();

        // Mientras los dos tengan salud
        do
        {
            Console.WriteLine("\nATACA PERSONAJE 1");
            if (saltar == "1")
            {
                Console.WriteLine("\nPresiona una tecla para que ataque...");
                Console.ReadKey();
            }

            Console.WriteLine("\nATACA: " + p1.Datos.Apodo);
            Console.WriteLine("Salud: " + p1.Caracteristicas.Salud);
            Console.WriteLine("Daño provocado: " + Danio(p1, p2));
            // Restar salud a personaje 2
            p2.Caracteristicas.Salud = Math.Max(0, p2.Caracteristicas.Salud - Danio(p1, p2));

            // Comprobar que el player 2 tenga salud todavia
            if (p2.Caracteristicas.Salud <= 0)
            {
                break;
            }

            Console.WriteLine("\nATACA PERSONAJE 2");
            if (saltar == "1")
            {
                Console.WriteLine("\nPresiona una tecla para que ataque...");
                Console.ReadKey();
            }

            Console.WriteLine("\nATACA: " + p2.Datos.Apodo);
            Console.WriteLine("Salud: " + p2.Caracteristicas.Salud);
            Console.WriteLine("Daño provocado: " + Danio(p2, p1));
            // Restar salud a personaje 1
            p1.Caracteristicas.Salud = Math.Max(0, p1.Caracteristicas.Salud - Danio(p2, p1));


        } while (p1.Caracteristicas.Salud > 0 && p2.Caracteristicas.Salud > 0);

        if (p1.Caracteristicas.Salud > 0)
        {
            return p1;
        }
        else
        {
            return p2;
        }
    }

    public static float BonusSalud(float saludInicial)
    {
        // Aumentar salud del ganador en 10, cada vez que gane
        return saludInicial += 10;
    }

    public static string LugarBatalla(Personaje player1, Personaje player2)
    {
        Random random = new Random();
        int i = random.Next(2);
        if (i == 1)
        {
            return player1.Datos.LugarDeNacimiento;
        }
        else
        {
            return player2.Datos.LugarDeNacimiento;
        }

    }
}