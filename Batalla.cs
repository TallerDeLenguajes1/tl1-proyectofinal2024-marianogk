using EspacioPersonaje;

public class Batalla
{
    Personaje personaje1, personaje2;

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
        return ((Ataque(p1) * Efectividad()) - Defensa(p2)) / 500;
    }

    // Combate de los 2 personajes
    public static Personaje Pelear(Personaje p1, Personaje p2)
    {

        // Mientras los dos tengan salud
        do
        {
            Console.WriteLine("Presiona una tecla para iniciar la batalla...");
            Console.ReadKey();
            // Player 1 ataca
            Console.WriteLine("\nATACA: " + p1.Datos.Apodo);
            Console.WriteLine("Salud: " + p1.Caracteristicas.Salud);
            Console.WriteLine("Daño provocado: " + Danio(p1, p2));
            p2.Caracteristicas.Salud = p2.Caracteristicas.Salud - Danio(p1, p2);

            // Comprobar que el player 2 tenga salud todavia
            if (p2.Caracteristicas.Salud <= 0)
            {
                Console.WriteLine("\n" + p2.Datos.Apodo + " HA SIDO DERROTADO");
                break;
            }

            // Player 2 ataca

            Console.WriteLine("\nATACA: " + p2.Datos.Apodo);
            Console.WriteLine("Salud: " + p2.Caracteristicas.Salud);
            Console.WriteLine("Daño provocado: " + Danio(p2, p1));
            p1.Caracteristicas.Salud = p1.Caracteristicas.Salud - Danio(p2, p1);

            // Comprobar que el player 1 tenga salud todavia
            if (p1.Caracteristicas.Salud <= 0)
            {
                Console.WriteLine("\n" + p2.Datos.Apodo + "  HA SIDO DERROTADO");
                break;
            }

        } while (p1.Caracteristicas.Salud > 0 && p2.Caracteristicas.Salud > 0);

        if (p2.Caracteristicas.Salud < 0)
        {
            return p1;
        }
        else
        {
            return p2;
        }
    }
}