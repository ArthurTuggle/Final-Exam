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
}
public void Display()

{
Console.WriteLine(base.artistinfo);
}
}