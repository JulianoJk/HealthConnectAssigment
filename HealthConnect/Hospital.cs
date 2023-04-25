using System;
using System.Collections.Generic;

public class Hospital
{
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }
    public List<Address> Addresses { get; set; }
    public List<Room> Room { get; set; }

    public Hospital()
    {
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
        Addresses = new List<Address>();
        Room = new List<Room>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }

    public void AddAddress(Address address)
    {
        Addresses.Add(address);
    }

    public void CallAllMethods()
    {
        AddDoctor(
            new Doctor
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 35,
                Salary = 150000,
                Patients = new List<Patient>()
            }
        );

        AddDoctor(
            new Doctor
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Age = 40,
                Salary = 160000,
                Patients = new List<Patient>()
            }
        );

        AddPatient(
            new Patient
            {
                Id = 1,
                FirstName = "James",
                LastName = "Wilson",
                Age = 45,
                Address = new Address
                {
                    Id = 1,
                    Name = "123 Main St",
                    Country = "USA",
                    City = "New York",
                    PostalCode = "10001",
                    Patients = new List<Patient>()
                },
            }
        );

        AddPatient(
            new Patient
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Johnson",
                Age = 30,
                Address = new Address
                {
                    Id = 2,
                    Name = "456 Park Ave",
                    Country = "USA",
                    City = "Los Angeles",
                    PostalCode = "90001",
                    Patients = new List<Patient>()
                },
            }
        );

        AddAddress(
            new Address
            {
                Id = 1,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            }
        );

        AddAddress(
            new Address
            {
                Id = 2,
                Name = "456 Park Ave",
                Country = "USA",
                City = "Los Angeles",
                PostalCode = "90001",
                Patients = new List<Patient>()
            }
        );
    }

    public void PrintDoctors()
    {
        Console.WriteLine("Doctors");
        Console.WriteLine("First Name\tLast Name\tAge\tSalary");
        foreach (var doctor in Doctors)
        {
            Console.WriteLine(
                $"{doctor.FirstName}\t{doctor.LastName}\t{doctor.Age}\t{doctor.Salary}"
            );
        }
        Console.WriteLine();
    }

    public void PrintAddresses()
    {
        Console.WriteLine("Addresses");
        Console.WriteLine("Name\tCountry\tCity\tPostal Code");
        foreach (var address in Addresses)
        {
            Console.WriteLine(
                $"{address.Name}\t{address.Country}\t{address.City}\t{address.PostalCode}"
            );
        }
        Console.WriteLine();
    }

    public void PrintPatients()
    {
        Console.WriteLine("Patients");
        Console.WriteLine(
            "First Name\tLast Name\tAge\tEntry Date\tExit Date\tAddress Name\tRoom Name\tDoctor Name"
        );
        foreach (var patient in Patients)
        {
            Console.WriteLine(
                $"{patient.FirstName}\t{patient.LastName}\t{patient.Age}\t{patient.EntryDate}\t{patient.ExitDate}\t{patient.Address.Name}\t{patient.Room.Name}\t{patient.Doctor.FirstName} {patient.Doctor.LastName}"
            );
        }
        Console.WriteLine();
    }

    public void PrintRooms()
    {
        Console.WriteLine("Rooms");
        Console.WriteLine("Name");
        foreach (var room in Room)
        {
            Console.WriteLine($"{room.Name}");
        }
    }
}
