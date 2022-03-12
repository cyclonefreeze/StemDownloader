using System;
using System.Linq;
using StemDownloader.Models;
using System.Collections.Generic;

namespace StemDownloader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var album = Util.GetResponse<Dictionary<string, Album>>("https://api.stemplayer.com/content/albums").FirstOrDefault(x => x.Key == "donda_2").Value; 
            foreach (var track in album.Tracks)
            {
                var url = Util.GetResponse<File>($"https://api.stemplayer.com/content/tracks/{track.Id}?version={track.Version}&codec=mp3").FileUrl;
                var path = Util.CreatePath(track);

                Console.WriteLine($"Downloading \"{track.Metadata.Title}\" to Music directory");

                Util.DownloadFile(url, path);
            }
        }
    }
}