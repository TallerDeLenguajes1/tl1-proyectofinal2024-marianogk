using System.Text.Json.Serialization;

namespace EspacioPersonaje
{
    public class Appearance
    {
        [JsonPropertyName("eye-color")]
        public string eyecolor { get; set; }

        [JsonPropertyName("hair-color")]
        public string haircolor { get; set; }
    }

    public class Biography
    {
        [JsonPropertyName("full-name")]
        public string Fullname { get; set; }
    }

    public class Root
    {
        public string response { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public Biography biography { get; set; }
        public Appearance appearance { get; set; }
    }

    public class Datos
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
    }
    public class Caracteristicas
    {
        public int Velocidad { get; set; } // 1 a 10
        public int Destreza { get; set; }  // 1 a 5
        public int Fuerza { get; set; }    // 1 a 10
        public int Nivel { get; set; }     // 1 a 10
        public int Armadura { get; set; }  // 1 a 10
        public float Salud { get; set; }     // 100
    }
    public class Personaje
    {
        public Datos Datos { get; set; }
        public Caracteristicas Caracteristicas { get; set; }
        public Root Root { get; set; }
    }

    
}