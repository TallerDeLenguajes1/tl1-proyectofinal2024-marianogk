using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

public class Program
{
    public static async Task Main(string[] args)
    {
        // Crear un indice aleatorio para la api del personaje
        Random randomId = new Random();
        int[] idsPersonajes = { 332, 659, 620, 623, 579, 165, 344, 720, 107, 69, 309, 370, 644, 149, 346, 263, 717, 655 };
        int idP = idsPersonajes[randomId.Next(0, idsPersonajes.Length)];

        Root salida = await Api.GetPersonaje(idP); // Obtener el personaje desde la API

        if (salida != null)
        {
            FabricaDePersonajes fabrica = new FabricaDePersonajes();
            List<Personaje> personajes = new List<Personaje>();

            Personaje personaje = fabrica.CrearPersonajeAleatorio(salida);
            personajes.Add(personaje);

            // Guardar personajes en JSON
            string nombreArchivo = @"C:\taller1\tl1-proyectofinal2024-marianogk\players.json";
            await PersonajesJson.GuardarPersonajes(personajes, nombreArchivo);
            Console.WriteLine("Personaje guardado en el archivo JSON correctamente: " + nombreArchivo);

            // Leer personajes desde JSON
            List<Personaje> personajesLeidos = await PersonajesJson.LeerPersonajes(nombreArchivo);
            if (personajesLeidos != null)
            {
                MostrarPersonajes(personajesLeidos);
            }
            else
            {
                Console.WriteLine("No se encontraron personajes en el archivo JSON.");
            }
        }
        else
        {
            Console.WriteLine("No se pudo obtener el personaje desde la API.");
        }

        static void MostrarPersonajes(List<Personaje> personajesLeidos)
        {
            Console.WriteLine("Personaje:");
            foreach (var pj in personajesLeidos)
            {
                Console.WriteLine("-DATOS-");
                Console.WriteLine("Tipo: " + pj.Datos.Tipo);
                Console.WriteLine("Nombre Completo: " + pj.Datos.Nombre);
                Console.WriteLine("Apodo: " + pj.Datos.Apodo);
                Console.WriteLine("Fecha de nacimiento: " + pj.Datos.FechaDeNacimiento);
                Console.WriteLine("Edad: " + pj.Datos.Edad);

                Console.WriteLine("-CARACTERISTICAS-");
                Console.WriteLine("Velocidad: " + pj.Caracteristicas.Velocidad);
                Console.WriteLine("Destreza: " + pj.Caracteristicas.Destreza);
                Console.WriteLine("Fuerza: " + pj.Caracteristicas.Fuerza);
                Console.WriteLine("Nivel: " + pj.Caracteristicas.Nivel);
                Console.WriteLine("Armadura: " + pj.Caracteristicas.Armadura);
                Console.WriteLine("Salud: " + pj.Caracteristicas.Salud);
            }
        }
    }

}