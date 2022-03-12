using Newtonsoft.Json;

namespace StemDownloader.Models
{
    internal class File
    {
        [JsonProperty("file")]
        public string FileUrl { get; set; }
    }
}
