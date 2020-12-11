using System; 
using System.Collections; 

class Artist { 
    
    public string FirstName { get; set; }  
    public string LastName { get; set; }  
    public string Email { get; set; }
    
   
    public Artist(string firstName, string lastName)
    {
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email="unknown";
    }
    
    
    public void Display() 
    { 
        Console.WriteLine("Artist's info: "+this.FirstName+" "+this.LastName);
    } 
} 