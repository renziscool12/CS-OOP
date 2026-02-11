namespace ConstructorParameter;

class Program
{
    static void Main(string[] args)
    {
        //Constructors can also take parameters,
        //which is used to initialize fields.
        Songs mySong = new Songs("My Immortal", "Evanescene", 2003 );
        
        Console.WriteLine("I love");
        Console.WriteLine($"{mySong.song} {mySong.artist} {mySong.year}");
        // Outputs My Immortal Evanescene 2003
    }
}

//CLASS
namespace ConstructorParameter;

class Songs
{
    public string song;
    public string artist;
    public int year;

    // Create a class constructor with multiple parameters
    public Songs(String song, String artist, int year)
    {

        this.song = song;
        this.artist = artist;
        this.year = year;
    }
}
