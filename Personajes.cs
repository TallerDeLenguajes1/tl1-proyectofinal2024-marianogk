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

        [JsonPropertyName("place-of-birth")]
        public string placeofbirth { get; set; }

        [JsonPropertyName("first-appearance")]
        public string firstappearance { get; set; }
        public string publisher { get; set; }
        public string Alignment { get; set; }
    }
    public class Work
    {
        public string occupation { get; set; }
        public string BaseT { get; set; }
    }
    public class Root
    {
        public string response { get; set; }
        public string Id { get; set; }
        public string name { get; set; }
        public Biography biography { get; set; }
        public Appearance Appearance { get; set; }
        public Work work { get; set; }
    }


    public class Datos
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Edad { get; set; }
        public string LugarDeNacimiento { get; set; }
        public string Comic { get; set; }
        public string Trabajo { get; set; }
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