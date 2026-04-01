using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 ave", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Blvd", "Kaysville", "UT", "USA");
        Address address3 = new Address("789 St", "Logan", "UT", "USA");

        Lecture lecture = new Lecture(
            "Science of Programming",
            "An in-depth look at programming concepts and techniques.",
            "April 20, 2026",
            "6:00 PM",
            address1,
            "Dr. Young",
            100
        );
        Reception reception = new Reception(
            "Tech Networking Event",
            "An opportunity to network with tech professionals.",
            "May 15, 2026",
            "7:00 PM",
            address2,
            "rsvp@events.com"
        );
        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Spring Festival",
            "A fun outdoor event with food, music, and games.",
            "June 10, 2026",
            "12:00 PM",
            address3,
            "Sunny with a chance of showers"
        );

        Console.WriteLine("LECTURE");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());


        Console.WriteLine("\n------------------------------\n");


        Console.WriteLine("RECEPTION");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());


        Console.WriteLine("\n------------------------------\n");
        

        Console.WriteLine("OUTDOOR GATHERING");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}