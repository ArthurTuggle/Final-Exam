using System;

namespace RentalApp
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
          var artist1 = new Artist(1,"Taylor Swift");
            
            artist1.DisplayInfo();
        
            Console.Read();
        }
    }
}