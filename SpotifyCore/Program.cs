using System;
using System.Collections.Generic;

namespace SpotifyCore
{
    class Program
    {
         static void Main(string[] args)
        {
            string menyVal = "";

            List<Artist> artists = new List<Artist>();
            List<Album> albums = new List<Album>();
            do
            {
                Meny();
                menyVal = Console.ReadLine();
                switch (menyVal)
                {
                    case "1":
                        Artist artist1 = new Artist();
                        Console.WriteLine("Ange namn på artist");
                        artist1.ArtistNamn = Console.ReadLine();
                        Console.WriteLine("Ålder");
                        artist1.Ålder = Convert.ToInt32(Console.ReadLine());
                        artists.Add(artist1);
                        break;

                    case "2":
                        Album album1 = new Album();
                        Console.WriteLine("Ange namn på album");
                        album1.AlbumNamn = Console.ReadLine();
                        Console.WriteLine("Ange releasedatum");
                        album1.ReleaseDatum = Convert.ToInt32(Console.ReadLine());
                        albums.Add(album1);
                        break;

                    case "3":
                        Console.WriteLine("Ange namnet på artisten du vill ta bort");
                        string artistNamn2 = Console.ReadLine();
                        Artist newArtist2 = artists.Find(x => x.ArtistNamn == artistNamn2);
                        artists.Remove(newArtist2);
                        break;

                    case "4":
                        Console.WriteLine("Ange namnet på albumet du vill ta bort");
                        string albumNamn2 = Console.ReadLine();
                        Album newAlbum2 = albums.Find(x => x.AlbumNamn == albumNamn2);
                        albums.Remove(newAlbum2);
                        break;
                        
                    case "5":
                        SkrivUt(artists);
                        break;

                    case "6":
                        SkrivUt(albums);
                        break;

                    case "7":
                        Console.WriteLine("Ange artistnamn på artisten du söker");
                        string valNamn = Console.ReadLine();
                        Artist newArtist = artists.Find(x => x.ArtistNamn == valNamn);
                        Console.WriteLine("Vad är artistnamnet");
                        newArtist.ArtistNamn = Console.ReadLine();
                        Console.WriteLine("Hur gammal är den");
                        newArtist.Ålder = Convert.ToInt32(Console.ReadLine());
                        break;

                    case "8":
                        Console.WriteLine("Ange albumnamn på album du söker");
                        string valAlbumNamn = Console.ReadLine();
                        Album newAlbum = albums.Find(x => x.AlbumNamn == valAlbumNamn);
                        Console.WriteLine("Vad är albumnamnet");
                        newAlbum.AlbumNamn = Console.ReadLine();
                        Console.WriteLine("Vilket år kom den");
                        newAlbum.ReleaseDatum = Convert.ToInt32(Console.ReadLine());
                        break;
                }

            } while (menyVal !="0");
        }
        private static void Meny()
        {

            Console.WriteLine("Gör ett val:");
            Console.WriteLine("1. Lägg till Artist");
            Console.WriteLine("2. Lägg till Album");
            Console.WriteLine("3. Ta Bort Artist");
            Console.WriteLine("4. Ta bort Album");
            Console.WriteLine("5. Skriv ut lista på sparade artister");
            Console.WriteLine("6. Skriv ut lista på sparade album");
            Console.WriteLine("7. Sök artist och ändra");
            Console.WriteLine("8. Sök album och ändra");
            Console.WriteLine("0. Avsluta");
            
        }
        public static void SkrivUt(IEnumerable<IInformation> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item.GetInformation());
            }
            
        }
    }
}
