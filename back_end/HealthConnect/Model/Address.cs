using System.Collections.Generic;

namespace HealthConnect.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
