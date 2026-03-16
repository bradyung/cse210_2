class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Bob", "Ross", 55, 195);
        Console.WriteLine(person.GetPersonInformation());
        Doctor doctor = new Doctor("Axe", "Bob", "Budge", 75, 210);
        Console.WriteLine(doctor.GetDoctorInformation());
    }

}

// Inheritance stuffs