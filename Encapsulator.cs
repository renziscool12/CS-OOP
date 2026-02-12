namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        /*The meaning of Encapsulation,
        is to make sure that "sensitive"
         data is hidden from users.*/ 
        
        //To achieve this, you must:
        //provide public get and set methods,
        //through properties, to access and update the value of a private field

        // Create a new Anime object
        Anime myAnime = new Anime();
        Console.WriteLine("Is your favorite anime GOATED?");

        // Loop until a valid AnimeName is entered
        // Uses the setter in Anime class for validation
        while (string.IsNullOrWhiteSpace(myAnime.AnimeName))
        {
            Console.Write("Your favorite anime: ");
            // Read user input trim extra spaces and assign to property
            myAnime.AnimeName = Console.ReadLine()?.Trim();
        }

        // Loop until a valid AnimeYear is entered
        while (true)
        {
            int year;
            Console.Write("Your favorite anime year: ");
            // Keep asking until the user enters a valid integer
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Please enter a valid year");
            }
            // Assign to AnimeYear property (setter validates)  
            myAnime.AnimeYear = year;
            // Break loop only if year is valid (setter ensures >1950)
            if (myAnime.AnimeYear > 1950)
            {
                break;
            }
            else
            {
                Console.Write("Please enter a valid year");
            }
        }
        
        // Loop until a valid boolean is entered for IsanimeGoated
        Console.Write("Is your favorite anime GOATED?(TRUE/FALSE): ");
        bool goated;
        while(!bool.TryParse(Console.ReadLine(), out goated))
        {
            Console.Write("Please enter true or false!");
        }
        // Assign to property (setter will print "GOATED!" if true)
        myAnime.IsanimeGoated = goated;
        
        Console.WriteLine();
        
        //SUMMARY
        Console.WriteLine($"Your favorite anime: {myAnime.AnimeName}");
        Console.WriteLine($"Your favorite anime year: {myAnime.AnimeYear}");
        Console.WriteLine($"Is it GOATED? {myAnime.IsanimeGoated}");

    }
}

//CLASS
using System.Text.RegularExpressions;

namespace Encapsulation;

class Anime
{
    // Private fields (encapsulation) — only accessible within this class
    private string _animeName = ""; 
    private int _animeYear;
    private bool _isanimeGoated;

    public string? AnimeName
    {
        // Public property for AnimeName
        // Uses getter/setter to control access to _animeName
        get { return _animeName; } 
        set
        {
            // Check if input is null or empty
            if(string.IsNullOrWhiteSpace(value))
                Console.WriteLine("LETTERS ONLY!");
            // Check if input contains any numbers
            else if (value.Any(char.IsDigit))
            {
                Console.WriteLine("ANIME NAME CANNOT CONTAIN NUMBERS");
            }
            // contains symbols, only letters and spaces allowed
            else if(!Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))
            {
               Console.WriteLine("Anime name can only contain letters and spaces!");
               
            }
            // Passed all checks → assign to private field
            else
            {
                _animeName = value;
            }
            
          
        }
    }

    // Public property for AnimeYear
    // Getter returns the private year
    // Setter validates before assigning
    public int AnimeYear
    {
        get { return _animeYear; } //return current year
        set
        {
            //accepts only year after 1950
            if (value > 1950)
            {
                _animeYear = value; //valid -> assign
                
            }
            else
            {
                Console.WriteLine("Anime year must be up 1950!"); // warning
            }
        }
    }

    // Public property for IsanimeGoated
    // Getter returns the private bool
    // Setter assigns and prints feedback if true
    public bool IsanimeGoated
    {   
        get { return _isanimeGoated; } //return current value
        set
        {
            _isanimeGoated = value; //assigned the value
            if (value) //feedback
            {
                Console.WriteLine("GOATED!");
            }
        }
    }
}
