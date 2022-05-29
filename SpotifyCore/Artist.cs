using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyCore
{
    class Artist:IInformation
    {
        public int Ålder { get; set; }
        public string ArtistNamn { get; set; }
        public string GetInformation()
        {
            return $"Artisten heter {ArtistNamn} och är {Ålder}år";
        }
    }
}
