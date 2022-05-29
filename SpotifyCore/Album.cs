using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyCore
{
    class Album: IInformation
    {
        public string AlbumNamn { get; set; }
        public int ReleaseDatum { get; set; }
        public string GetInformation()
        {
            return $"Namnet på albumet är {AlbumNamn} och släpptes {ReleaseDatum}";
        }
    }
}
