
using Activity_ADT;

internal class Program
{
    private static void Main(string[] args)
    {
        Vehicle[] vehicle = new Vehicle[10];
        License[] licence = new License[10];
        Person[] person = new Person[10];
        Register reg = new Register();

        Person p1 = new Person();
        License l1 = new License();
        Vehicle v1 = new Vehicle();

        p1.name = "Pepito";
        p1.Surname = "Perez";
        p1.Age = 55;
        p1.gender = "Male";
        p1.key = 123;
        p1.Suspicion = false;

        l1.date = "19-09-22";
        l1.expiration = "19-09-25";
        l1.key_person = 123;
        l1.status = true;
        l1.type = "T1";
        p1.licenses.Add(l1);

        v1.brand = "Toyota";
        v1.color = "Red";
        v1.description = "Car";
        v1.type_License = "T1";
        v1.wheels = "";
        v1.year = 2022;
        p1.Vehicles.Add(v1);


    }
}