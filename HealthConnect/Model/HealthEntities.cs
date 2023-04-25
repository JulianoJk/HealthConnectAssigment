using System;
using System.Collections.Generic;

public class Doctor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public List<Patient> Patients { get; set; }
}

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

public class Address
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public List<Patient> Patients { get; set; }
}

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Patient> Patients { get; set; }
}
