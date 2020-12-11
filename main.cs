using System;

 static public void Main() 
    { 
        
        Artist artist = new Artist("Taylor","Swift"); 
        artist.Display(); 
        
        
        Song s1 = new Song(1246467891,"22");
        Song s2 = new Song(2334567891,"Blank Space");
        Song s3 = new Song(3234567891,"Style");
        
        
        Console.WriteLine();
        s1.AddArtistInfo(artist);
        s2.AddArtistInfo(artist);
        s3.AddArtistInfo(artist);
        
        
        Console.WriteLine();
        s1.Display();
        s2.Display();
        s3.Display();
    } 
}