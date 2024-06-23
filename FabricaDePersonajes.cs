using System.ComponentModel;
using System.Globalization;
using EspacioPersonaje;
class FabricaDePersonajes
{

    private static readonly Random random = new Random();

    public Personaje CrearPersonajeAleatorio(Result apiResult)
    {
        Datos datos = new Datos
        {
            Tipo = apiResult.appearance.Race,
            Nombre = apiResult.biography.Fullname,
            Apodo = apiResult.name,
            FechaDeNacimiento = apiResult.biography.FechaNacimiento,
            Edad = CalcularEdad(apiResult.biography.FechaNacimiento)
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
            Result = apiResult
            };
    }

    private int CalcularEdad(string fechaNacimiento)
    {
        // Convertir la fecha string en datetime
        string formato = "dd/MM/yyyy"; // Formato

        DateTime fecha = DateTime.ParseExact(fechaNacimiento, formato, CultureInfo.InvariantCulture);

        int edad = DateTime.Today.Year - fecha.Year;

        return edad;
    }
}