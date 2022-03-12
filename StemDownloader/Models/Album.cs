using Newtonsoft.Json;
using System.Collections.Generic;

namespace StemDownloader.Models
{
    internal class Album
    {
        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artists")]
        public List<string> Artists { get; set; }

        [JsonProperty("paid_content")]
        public bool PaidContent { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tracks")]
        public List<Track> Tracks { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
