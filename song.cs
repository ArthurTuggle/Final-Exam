using System;
using System;
class song

{

public string id { get; set; }

public string title { get; set; }

public string artistinfo { get; set; }


public artist(string id, string title,string artistinfo)

{
Id = id;

Title = title;

Artistinfo = artistinfo;
 { 
        this.ArtistInfo=artist;
        Console.WriteLine("Artist "+this.ArtistInfo.FirstName+" "+this.ArtistInfo.LastName+
                         " added the song titled "+this.Title);
    } 
    
    //this will display Song info 
    public void Display() 
    { 
        Console.WriteLine("Song info is: "+this.Id+" "+this.Title+" "+
                           this.ArtistInfo.FirstName+" "+this.ArtistInfo.LastName);
    } 
} 