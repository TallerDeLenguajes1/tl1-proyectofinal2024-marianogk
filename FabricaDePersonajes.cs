using System.ComponentModel;
using System.Globalization;
using System.Text.Json;
using EspacioPersonaje;
class FabricaDePersonajes
{
    private static readonly Random random = new Random();
    private readonly string[] tipo = {"Superheroe", "Villano"};
    public Personaje CrearPersonajeAleatorio(Root apiResult)
    {
        int i = random.Next(2);
        DateTime fechaNacimiento = GenerarNacimiento();
        
        Datos datos = new()
        {
            Tipo = tipo[i],
            Nombre = apiResult.biography.Fullname,
            Apodo = apiResult.name,
            FechaDeNacimiento = fechaNacimiento,
            Edad = CalcularEdad(fechaNacimiento),
            LugarDeNacimiento = apiResult.biography.placeofbirth,
            Comic = apiResult.biography.publisher,
            Trabajo = apiResult.work.occupation
        };

        Caracteristicas caracteristicas = new Caracteristicas
        {
            Velocidad = random.Next(1, 11),
            Destreza = random.Next(1, 6),
            Fuerza = random.Next(1, 11),
            Nivel = random.Next(1, 11),
            Armadura = random.Next(1, 11),
            Salud = 100
        };

        return new Personaje
        {
            Datos = datos,
            Caracteristicas = caracteristicas,
            Root = apiResult
        };
    }

    private static DateTime GenerarNacimiento()
    {
        int year = random.Next(1900, 2015);
        int month = random.Next(1, 13);

        int maxDay = DateTime.DaysInMonth(year, month);

        // Generamos un día aleatorio dentro del rango válido para el mes
        int day = random.Next(1, maxDay + 1);

        // Retorna la fecha de nacimiento aleatoria
        return new DateTime(year, month, day);
    }
    private static int CalcularEdad(DateTime fechaNacimiento)
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;

        // Si aun no cumplio, resta uno
        if (DateTime.Today < fechaNacimiento.AddYears(edad))
        {
            edad--;
        }

        return edad;
    }
}