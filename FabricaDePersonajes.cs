using System.ComponentModel;
using System.Globalization;
using System.Text.Json;
using EspacioPersonaje;
class FabricaDePersonajes
{

    private static readonly Random random = new Random();

    public Personaje CrearPersonajeAleatorio(Root apiResult)
    {
        Datos datos = new Datos
        {
            Tipo = null,
            Nombre = apiResult.biography.Fullname,
            Apodo = apiResult.name,
            FechaDeNacimiento = GenerarNacimiento(),
            Edad = CalcularEdad(GenerarNacimiento())
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

    private DateTime GenerarNacimiento()
    {
        int year = random.Next(1900, 2015);
        int month = random.Next(1, 13);

        int maxDay = DateTime.DaysInMonth(year, month);

        // Generamos un día aleatorio dentro del rango válido para el mes
        int day = random.Next(1, maxDay + 1);

        // Creamos la fecha de nacimiento aleatoria
        DateTime fechaNacimiento = new DateTime(year, month, day);

        return fechaNacimiento;
    }
    private int CalcularEdad(DateTime fechaNacimiento)
    {
        int edad = DateTime.Today.Year - fechaNacimiento.Year;

        return edad;
    }
}