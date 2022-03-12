using Newtonsoft.Json;
using System.Collections.Generic;

namespace StemDownloader.Models
{
    internal class Track
    {
        [JsonProperty("formats")]
        public List<string> Formats { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("paid_content")]
        public bool PaidContent { get; set; }

        [JsonProperty("stems_version")]
        public string StemsVersion { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    internal class Metadata
    {
        [JsonProperty("artists")]
        public List<string> Artists { get; set; }

        [JsonProperty("color")]
        public List<string> Color { get; set; }

        [JsonProperty("gain")]
        public double Gain { get; set; }

        [JsonProperty("stem_size")]
        public Dictionary<string, int> StemSize { get; set; }

        [JsonProperty("tempos")]
        public List<Tempo> Tempos { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class Tempo
    {
        [JsonProperty("tempo_bpm")]
        public int TempoBpm { get; set; }

        [JsonProperty("time_ms")]
        public int TimeMs { get; set; }
    }
}
