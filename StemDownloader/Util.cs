using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using StemDownloader.Models;

using File = System.IO.File;

namespace StemDownloader
{
    internal static class Util
    {
        public static T GetResponse<T>(string endpoint)
        {
            using var wc = new WebClient();
            wc.Headers[HttpRequestHeader.Authorization] = "basic eWVAZ21haWwuY29tOjE2NDcwODkyMDEyODU=";
            return JsonConvert.DeserializeObject<StemResponse<T>>(wc.DownloadString(endpoint)).Data;
        }

        public static void DownloadFile(string endpoint, string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File already exists, skipping");
                return;
            }

            using var wc = new WebClient();
            File.WriteAllBytes(path, wc.DownloadData(endpoint));
        }

        public static string CreatePath(Track track)
        {
            var musicDir = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            return Path.Combine(musicDir, $"{track.Metadata.Artists.First()} - {track.Metadata.Title}.mp3");
        }
    }
}