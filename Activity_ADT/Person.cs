using System;
namespace Activity_ADT
{
    public class Person
    {
        public List<License> licenses { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public String name { get; set; }
        public String Surname { get; set; }
        public int  Age { get; set; }
        public string gender { get; set; }
        public bool Suspicion { get; set; }
        public int key { get; set; }

        public Person()
        {
            this.licenses = new List<License>();
            this.Vehicles = new List<Vehicle>();
        }
    }
}

