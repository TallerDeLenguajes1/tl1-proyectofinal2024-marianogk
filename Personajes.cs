using System.Text.Json.Serialization;
 public class Appearance
    {
        public string gender { get; set; }
        public string race { get; set; }
        public List<string> height { get; set; }
        public List<string> weight { get; set; }

        [JsonPropertyName("eye-color")]
        public string eyecolor { get; set; }

        [JsonPropertyName("hair-color")]
        public string haircolor { get; set; }
    }

    public class Biography
    {
        [JsonPropertyName("full-name")]
        public string fullname { get; set; }

        [JsonPropertyName("alter-egos")]
        public string alteregos { get; set; }
        public List<string> aliases { get; set; }

        [JsonPropertyName("place-of-birth")]
        public string placeofbirth { get; set; }

        [JsonPropertyName("first-appearance")]
        public string firstappearance { get; set; }
        public string publisher { get; set; }
        public string alignment { get; set; }
    }

    public class Connections
    {
        [JsonPropertyName("group-affiliation")]
        public string groupaffiliation { get; set; }
        public string relatives { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
    }

    public class Powerstats
    {
        public string intelligence { get; set; }
        public string strength { get; set; }
        public string speed { get; set; }
        public string durability { get; set; }
        public string power { get; set; }
        public string combat { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        public string name { get; set; }
        public Powerstats powerstats { get; set; }
        public Biography biography { get; set; }
        public Appearance appearance { get; set; }
        public Work work { get; set; }
        public Connections connections { get; set; }
        public Image image { get; set; }
    }

    public class Root
    {
        public string response { get; set; }

        [JsonPropertyName("results-for")]
        public string resultsfor { get; set; }
        public List<Result> results { get; set; }
    }

    public class Work
    {
        public string occupation { get; set; }
        public string @base { get; set; }
    }

