namespace HealthConnect.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public Address Address { get; set; }
        public Room Room { get; set; }
        public Doctor Doctor { get; set; }
    }

}
