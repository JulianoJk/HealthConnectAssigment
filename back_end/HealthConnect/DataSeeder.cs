using HealthConnect.Model;
using System;
using System.Collections.Generic;

public class DataSeeder
{
    public List<Doctor> SeedDoctors()
    {
        var doctors = new List<Doctor>
        {
            new Doctor
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Age = 35,
                Salary = 100000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Age = 40,
                Salary = 120000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 3,
                FirstName = "Mark",
                LastName = "Johnson",
                Age = 45,
                Salary = 130000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 4,
                FirstName = "John",
                LastName = "Smith",
                Age = 35,
                Salary = 100000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 5,
                FirstName = "Mary",
                LastName = "Johnson",
                Age = 40,
                Salary = 120000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 6,
                FirstName = "Noah",
                LastName = "Bird",
                Age = 45,
                Salary = 130000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 7,
                FirstName = "Callum",
                LastName = "Mills",
                Age = 35,
                Salary = 100000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 8,
                FirstName = "Liam",
                LastName = "Smith",
                Age = 40,
                Salary = 120000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 9,
                FirstName = "Mason",
                LastName = "Johnson",
                Age = 45,
                Salary = 130000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 10,
                FirstName = "Jacob",
                LastName = "Smith",
                Age = 35,
                Salary = 100000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 11,
                FirstName = "Jocelyn",
                LastName = "Vincent",
                Age = 40,
                Salary = 120000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 12,
                FirstName = "Ava",
                LastName = "Johnson",
                Age = 45,
                Salary = 130000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 13,
                FirstName = "Olivia",
                LastName = "Smith",
                Age = 35,
                Salary = 100000,
                Patients = new List<Patient>()
            },
        };

        return doctors;
    }

    public List<Address> SeedAddresses()
    {
        var addresses = new List<Address>
        {
            new Address
            {
                Id = 1,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 2,
                Name = "456 Park Ave",
                Country = "USA",
                City = "Los Angeles",
                PostalCode = "90001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 3,
                Name = "789 Broad St",
                Country = "USA",
                City = "Chicago",
                PostalCode = "60601",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 4,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 5,
                Name = "456 Park Ave",
                Country = "USA",
                City = "Los Angeles",
                PostalCode = "90001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 6,
                Name = "789 Broad St",
                Country = "USA",
                City = "Chicago",
                PostalCode = "60601",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 7,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 8,
                Name = "456 Park Ave",
                Country = "USA",
                City = "Los Angeles",
                PostalCode = "90001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 9,
                Name = "789 Broad St",
                Country = "USA",
                City = "Chicago",
                PostalCode = "60601",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 10,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 11,
                Name = "456 Park Ave",
                Country = "USA",
                City = "Los Angeles",
                PostalCode = "90001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 12,
                Name = "789 Broad St",
                Country = "USA",
                City = "Chicago",
                PostalCode = "60601",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 13,
                Name = "123 Main St",
                Country = "USA",
                City = "New York",
                PostalCode = "10001",
                Patients = new List<Patient>()
            },
        };

        return addresses;
    }

    public List<Patient> SeedPatients(
        List<Address> addresses,
        List<Room> rooms,
        List<Doctor> doctors
    )
    {
        var patients = new List<Patient>
        {
            new Patient
            {
                Id = 1,
                FirstName = "Sarah",
                LastName = "Johnson",
                Age = 25,
                EntryDate = new DateTime(2022, 1, 1),
                ExitDate = new DateTime(2022, 1, 10),
                Address = addresses[0],
                Room = rooms[0],
                Doctor = doctors[0]
            },
            new Patient
            {
                Id = 2,
                FirstName = "Tom",
                LastName = "Smith",
                Age = 30,
                EntryDate = new DateTime(2022, 2, 1),
                ExitDate = new DateTime(2022, 2, 10),
                Address = addresses[1],
                Room = rooms[1],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 3,
                FirstName = "Emma",
                LastName = "Brown",
                Age = 35,
                EntryDate = new DateTime(2022, 3, 1),
                ExitDate = new DateTime(2022, 3, 10),
                Address = addresses[2],
                Room = rooms[2],
                Doctor = doctors[2]
            },
            // 10 new Patient
            new Patient
            {
                Id = 4,
                FirstName = "Sarah",
                LastName = "Johnson",
                Age = 25,
                EntryDate = new DateTime(2022, 1, 1),
                ExitDate = new DateTime(2022, 1, 10),
                Address = addresses[3],
                Room = rooms[3],
                Doctor = doctors[3]
            },
            new Patient
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Smith",
                Age = 30,
                EntryDate = new DateTime(2022, 2, 1),
                ExitDate = new DateTime(2022, 2, 10),
                Address = addresses[4],
                Room = rooms[4],
                Doctor = doctors[4]
            },
            new Patient
            {
                Id = 6,
                FirstName = "Emma",
                LastName = "Brown",
                Age = 35,
                EntryDate = new DateTime(2022, 3, 1),
                ExitDate = new DateTime(2022, 3, 10),
                Address = addresses[5],
                Room = rooms[5],
                Doctor = doctors[5]
            },
            new Patient
            {
                Id = 7,
                FirstName = "Sarah",
                LastName = "Johnson",
                Age = 25,
                EntryDate = new DateTime(2022, 1, 1),
                ExitDate = new DateTime(2022, 1, 10),
                Address = addresses[6],
                Room = rooms[6],
                Doctor = doctors[6]
            },
            new Patient
            {
                Id = 8,
                FirstName = "Tom",
                LastName = "Smith",
                Age = 30,
                EntryDate = new DateTime(2022, 2, 1),
                ExitDate = new DateTime(2022, 2, 10),
                Address = addresses[7],
                Room = rooms[7],
                Doctor = doctors[7]
            },
            new Patient
            {
                Id = 9,
                FirstName = "Emma",
                LastName = "Brown",
                Age = 35,
                EntryDate = new DateTime(2022, 3, 1),
                ExitDate = new DateTime(2022, 3, 10),
                Address = addresses[8],
                Room = rooms[8],
                Doctor = doctors[8]
            },
            new Patient
            {
                Id = 10,
                FirstName = "Sarah",
                LastName = "Johnson",
                Age = 25,
                EntryDate = new DateTime(2022, 1, 1),
                ExitDate = new DateTime(2022, 1, 10),
                Address = addresses[9],
                Room = rooms[9],
                Doctor = doctors[9]
            },
            new Patient
            {
                Id = 11,
                FirstName = "Tom",
                LastName = "Smith",
                Age = 30,
                EntryDate = new DateTime(2022, 2, 1),
                ExitDate = new DateTime(2022, 2, 10),
                Address = addresses[10],
                Room = rooms[10],
                Doctor = doctors[10]
            },
            new Patient
            {
                Id = 12,
                FirstName = "Emma",
                LastName = "Brown",
                Age = 35,
                EntryDate = new DateTime(2022, 3, 1),
                ExitDate = new DateTime(2022, 3, 10),
                Address = addresses[11],
                Room = rooms[11],
                Doctor = doctors[11]
            },
            new Patient
            {
                Id = 13,
                FirstName = "Emma",
                LastName = "Brown",
                Age = 35,
                EntryDate = new DateTime(2022, 3, 1),
                ExitDate = new DateTime(2022, 3, 10),
                Address = addresses[12],
                Room = rooms[12],
                Doctor = doctors[12]
            },
        };

        // Add patients to their respective addresses and rooms
        addresses[0].Patients.Add(patients[0]);
        addresses[1].Patients.Add(patients[1]);
        addresses[2].Patients.Add(patients[2]);

        rooms[0].Patients.Add(patients[0]);
        rooms[1].Patients.Add(patients[1]);
        rooms[2].Patients.Add(patients[2]);

        // Add patients to their respective doctors
        doctors[0].Patients.Add(patients[0]);
        doctors[1].Patients.Add(patients[1]);
        doctors[2].Patients.Add(patients[2]);

        return patients;
    }

    public List<Room> SeedRooms()
    {
        var rooms = new List<Room>
        {
            new Room
            {
                Id = 1,
                Name = "Room 2",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 2,
                Name = "Room 4",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 3,
                Name = "Room 6",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 4,
                Name = "Room 2",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 5,
                Name = "Room 4",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 6,
                Name = "Room 6",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 7,
                Name = "Room 2",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 8,
                Name = "Room 4",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 9,
                Name = "Room 6",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 10,
                Name = "Room 2",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 11,
                Name = "Room 4",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 12,
                Name = "Room 6",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 13,
                Name = "Room 6",
                Patients = new List<Patient>()
            },
        };
        return rooms;
    }
}
