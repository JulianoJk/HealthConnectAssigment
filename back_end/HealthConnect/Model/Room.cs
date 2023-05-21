using System.Collections.Generic;

namespace HealthConnect.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
