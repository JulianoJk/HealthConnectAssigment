using System.Collections.Generic;

namespace HealthConnect.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
