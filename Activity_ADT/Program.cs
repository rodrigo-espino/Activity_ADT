
using Activity_ADT;

internal class Program
{
    private static void Main(string[] args)
    {
        Person[] person = new Person[20];
        Person p1 = new Person();

        p1.name = "Fernanda";
        p1.Surname = "Montes";
        p1.Age = 20;
        p1.gender = "Woman";
        p1.Suspicion = false;
        p1.key = 1234;

        License[] licenses = new License[20];
        License l1 = new License();

        l1.date = "19-09-22";
        l1.expiration = "29-08-25";
        l1.status = true;
        l1.type = "T1";
        l1.key_person = 1234;

        l1.VerifyAge(p1, l1);
        

        Vehicle[] vehicles = new Vehicle[20];
        Vehicle v1 = new Vehicle();

        v1.year = 2022;
        v1.brand = "Mercedes";
        v1.description = "Car";
        v1.wheels = 4;
        v1.color = "red";
        v1.type_License = "T1";
        v1.AddVehicle(l1, v1);

        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");
    }
}