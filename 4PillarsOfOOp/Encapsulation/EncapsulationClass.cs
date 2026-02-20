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
