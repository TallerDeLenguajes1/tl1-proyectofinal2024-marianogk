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
            Root = apiResult
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

    public class Api
{

// public static async Task<Root> GetPersonaje(int idP)
// {
//     var url = $"https://www.superheroapi.com/api.php/05d397d99a857530dc23cf8bd992412d/{idP}";

//     try
//     {
//         HttpClient client = new HttpClient();
//         HttpResponseMessage response = await client.GetAsync(url);
//         response.EnsureSuccessStatusCode();
//         string responseBody = await response.Content.ReadAsStringAsync();

//         Root personaje = JsonSerializer.Deserialize<Root>(responseBody);
//         return personaje;
//     }
//     catch (HttpRequestException e)
//     {
//         Console.WriteLine("Problemas de acceso a la API");
//         Console.WriteLine($"Error al realizar la solicitud HTTP: {e.Message}");
//         return null;
//     }
//     catch (JsonException e)
//     {
//         Console.WriteLine($"Error de deserialización JSON: {e.Message}");
//         return null;
//     }
// }
}
}