using System.Text.Json;
using System.Net.WebSockets;
using System.IO;
using EspacioPersonaje;

// Crear un indice aleatorio para la api del personaje
Random randomId = new Random();
int idP;
int[] idsPersonajes = [332,659,620,623,579,165,344,720,107,69,309,370,644,149,346,263,717,655];
int i = randomId.Next(0,idsPersonajes.Length);
idP = idsPersonajes[i];
Console.WriteLine("id: " + idP + "\n");

Root salida = await Api.GetPersonaje(idP);

Console.WriteLine(salida.name + "\n");
Console.WriteLine(salida.biography.Fullname + "\n");
