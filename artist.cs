using System;

class Artist

{

public string fname { get; set; }

public string lname { get; set; }

public string email { get; set; }


public Artist(string fname, string lname,string email)

{
FirstName = fname;

LastName = lname;

Email ="unknown";
}
public void Display()

{
  Console.WriteLine(" Name=" + base.FirstName + " " + base.LastName);
}
}
