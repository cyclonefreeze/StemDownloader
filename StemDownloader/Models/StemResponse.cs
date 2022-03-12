using Newtonsoft.Json;

namespace StemDownloader.Models
{
    internal class StemResponse<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
