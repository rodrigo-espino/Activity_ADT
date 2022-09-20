using System;
namespace Activity_ADT
{
    public class Register
    {
        private bool reg = true;
        private int cars_count = 0;
        private List<Person> regist { get; set; }

        public Register()
        {
            this.regist = new List<Person>();
        }

        public void RegPerson(Person person)
        {
            if(person.Age >= 90)
            {
                Console.WriteLine("You can't be registered");
                reg = false;
                
            }
            else
            {
                
                if(person.gender == "Male")
                {
                    foreach(Vehicle vehicle in person.Vehicles)
                    {
                        if(vehicle.brand != "Toyota" || vehicle.brand != "Ford")
                        {
                            Console.WriteLine("You cannot be registered");
                            reg = false;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (Vehicle vehicle in person.Vehicles)
                    {
                        if (vehicle.color != "red")
                        {
                            Console.WriteLine("You can't be registered");
                            reg = false;
                            break;
                        }
                        
                    }
                }

                foreach(Vehicle vehicle in person.Vehicles)
                {
                    cars_count += 1;
                }

                if(cars_count >= 5)
                {
                    person.Suspicion = true;
                }
            }
            

            if(reg == true)
            {
                this.regist.Add(person);
            }
        }




    }
}

