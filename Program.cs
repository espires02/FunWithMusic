namespace FunWithMusic
{
    internal class Program
    {
        enum Genre
        {
            Rap,
            Classic,
            Alternative,
            Jazz,
            Pop
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private float Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, float length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(float length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is it from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("How long is it?");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("R - rap \nC - classic rock \nA - alternative rock \nP - pop \nJ - jazz");
            Genre tempGenre = Genre.Rap;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'R':
                    tempGenre = Genre.Rap;
                    break;
                case 'C':
                    tempGenre = Genre.Classic;
                    break;
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, float.Parse(tempLength), tempGenre);

            Music moreMusic = music;

            Console.WriteLine("What is the next song on the album?");
            moreMusic.setTitle(Console.ReadLine());
            Console.WriteLine("How long is the song?");
            moreMusic.setLength(float.Parse(Console.ReadLine()));

            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}


