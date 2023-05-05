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
                Age = 40,
                Salary = 100000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Age = 50,
                Salary = 200000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 3,
                FirstName = "Bob",
                LastName = "Smith",
                Age = 60,
                Salary = 300000,
                Patients = new List<Patient>()
            },
            new Doctor
            {
                Id = 4,
                FirstName = "Alice",
                LastName = "Doe",
                Age = 70,
                Salary = 400000,
                Patients = new List<Patient>()
            }
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
                Name = "Poseidonos 12",
                Country = "Greece",
                City = "Athens",
                PostalCode = "18121",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 3,
                Name = "Kifisias 12",
                Country = "Greece",
                City = "Athens",
                PostalCode = "10721",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 4,
                Name = "Kaiserstrasse 12",
                Country = "Germany",
                City = "Berlin",
                PostalCode = "10115",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 5,
                Name = "Kurfürstendamm 12",
                Country = "Germany",
                City = "Berlin",
                PostalCode = "10719",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 6,
                Name = "Rue de Rivoli 12",
                Country = "France",
                City = "Paris",
                PostalCode = "75001",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 7,
                Name = "Rue de la Paix 12",
                Country = "France",
                City = "Paris",
                PostalCode = "75002",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 8,
                Name = "Via del Corso 12",
                Country = "Italy",
                City = "Rome",
                PostalCode = "00186",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 9,
                Name = "Via dei Condotti 12",
                Country = "Italy",
                City = "Rome",
                PostalCode = "00187",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 10,
                Name = "Calle de Alcalá 12",
                Country = "Spain",
                City = "Madrid",
                PostalCode = "28014",
                Patients = new List<Patient>()
            },
            new Address
            {
                Id = 11,
                Name = "Calle de Serrano 12",
                Country = "Spain",
                City = "Madrid",
                PostalCode = "28001",
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
                Address = addresses[1],
                Room = rooms[1],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 2,
                FirstName = "Michael",
                LastName = "Scott",
                Age = 40,
                EntryDate = new DateTime(2005, 1, 1),
                ExitDate = new DateTime(2005, 1, 10),
                Address = addresses[1],
                Room = rooms[1],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 3,
                FirstName = "Dwight",
                LastName = "Schrute",
                Age = 30,
                EntryDate = new DateTime(2006, 1, 1),
                ExitDate = new DateTime(2006, 1, 10),
                Address = addresses[2],
                Room = rooms[2],
                Doctor = doctors[2]
            },
            new Patient
            {
                Id = 4,
                FirstName = "Jim",
                LastName = "Halpert",
                Age = 30,
                EntryDate = new DateTime(2007, 1, 1),
                ExitDate = new DateTime(2007, 1, 10),
                Address = addresses[3],
                Room = rooms[3],
                Doctor = doctors[3]
            },
            new Patient
            {
                Id = 5,
                FirstName = "Pam",
                LastName = "Beesly",
                Age = 30,
                EntryDate = new DateTime(2008, 1, 1),
                ExitDate = new DateTime(2008, 1, 10),
                Address = addresses[4],
                Room = rooms[4],
                Doctor = doctors[4]
            },
            new Patient
            {
                Id = 6,
                FirstName = "Ryan",
                LastName = "Howard",
                Age = 30,
                EntryDate = new DateTime(2009, 1, 1),
                ExitDate = new DateTime(2009, 1, 10),
                Address = addresses[1],
                Room = rooms[3],
                Doctor = doctors[2]
            },
            new Patient
            {
                Id = 7,
                FirstName = "Andy",
                LastName = "Bernard",
                Age = 30,
                EntryDate = new DateTime(2010, 1, 1),
                ExitDate = new DateTime(2010, 1, 10),
                Address = addresses[2],
                Room = rooms[5],
                Doctor = doctors[3]
            },
            new Patient
            {
                Id = 8,
                FirstName = "Robert",
                LastName = "California",
                Age = 30,
                EntryDate = new DateTime(2011, 1, 1),
                ExitDate = new DateTime(2011, 1, 10),
                Address = addresses[7],
                Room = rooms[1],
                Doctor = doctors[4]
            },
            new Patient
            {
                Id = 9,
                FirstName = "Kevin",
                LastName = "Malone",
                Age = 30,
                EntryDate = new DateTime(2012, 1, 1),
                ExitDate = new DateTime(2012, 1, 10),
                Address = addresses[8],
                Room = rooms[1],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 10,
                FirstName = "Angela",
                LastName = "Martin",
                Age = 30,
                EntryDate = new DateTime(2013, 1, 1),
                ExitDate = new DateTime(2013, 1, 10),
                Address = addresses[9],
                Room = rooms[8],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 11,
                FirstName = "Oscar",
                LastName = "Martinez",
                Age = 30,
                EntryDate = new DateTime(2014, 1, 1),
                ExitDate = new DateTime(2014, 1, 10),
                Address = addresses[10],
                Room = rooms[8],
                Doctor = doctors[2]
            },
            new Patient
            {
                Id = 12,
                FirstName = "Meredith",
                LastName = "Palmer",
                Age = 30,
                EntryDate = new DateTime(2015, 1, 1),
                ExitDate = new DateTime(2015, 1, 10),
                Address = addresses[11],
                Room = rooms[4],
                Doctor = doctors[3]
            },
            new Patient
            {
                Id = 13,
                FirstName = "Creed",
                LastName = "Bratton",
                Age = 30,
                EntryDate = new DateTime(2016, 1, 1),
                ExitDate = new DateTime(2016, 1, 10),
                Address = addresses[6],
                Room = rooms[1],
                Doctor = doctors[4]
            },
            new Patient
            {
                Id = 14,
                FirstName = "Kelly",
                LastName = "Kapoor",
                Age = 30,
                EntryDate = new DateTime(2017, 1, 1),
                ExitDate = new DateTime(2017, 1, 10),
                Address = addresses[3],
                Room = rooms[1],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 15,
                FirstName = "Toby",
                LastName = "Flenderson",
                Age = 30,
                EntryDate = new DateTime(2018, 1, 1),
                ExitDate = new DateTime(2018, 1, 10),
                Address = addresses[3],
                Room = rooms[2],
                Doctor = doctors[1]
            },
            new Patient
            {
                Id = 16,
                FirstName = "Stanley",
                LastName = "Hudson",
                Age = 30,
                EntryDate = new DateTime(2019, 1, 1),
                ExitDate = new DateTime(2019, 1, 10),
                Address = addresses[3],
                Room = rooms[7],
                Doctor = doctors[1]
            },
        };

        // Add patients to their respective addresses and rooms based on their patient address
        addresses[1].Patients.Add(patients[5]);
        addresses[1].Patients.Add(patients[1]);
        addresses[1].Patients.Add(patients[2]);
        addresses[1].Patients.Add(patients[6]);
        addresses[2].Patients.Add(patients[3]);
        addresses[2].Patients.Add(patients[2]);
        addresses[2].Patients.Add(patients[13]);
        addresses[2].Patients.Add(patients[14]);
        addresses[2].Patients.Add(patients[15]);
        addresses[3].Patients.Add(patients[4]);
        addresses[5].Patients.Add(patients[12]);
        addresses[6].Patients.Add(patients[7]);
        addresses[7].Patients.Add(patients[8]);
        addresses[8].Patients.Add(patients[9]);
        addresses[9].Patients.Add(patients[10]);
        addresses[10].Patients.Add(patients[11]);

        // Add patients to their respective doctors
        doctors[1].Patients.Add(patients[1]);
        doctors[1].Patients.Add(patients[9]);
        doctors[1].Patients.Add(patients[14]);
        doctors[1].Patients.Add(patients[8]);
        doctors[1].Patients.Add(patients[13]);
        doctors[2].Patients.Add(patients[2]);
        doctors[2].Patients.Add(patients[10]);
        doctors[2].Patients.Add(patients[5]);
        doctors[3].Patients.Add(patients[3]);
        doctors[3].Patients.Add(patients[11]);
        doctors[3].Patients.Add(patients[6]);
        doctors[4].Patients.Add(patients[4]);
        doctors[4].Patients.Add(patients[12]);
        doctors[4].Patients.Add(patients[7]);

        // Add patients to their respective rooms based on their patient room
        rooms[1].Patients.Add(patients[11]);
        rooms[1].Patients.Add(patients[1]);
        rooms[1].Patients.Add(patients[8]);
        rooms[1].Patients.Add(patients[13]);
        rooms[2].Patients.Add(patients[2]);
        rooms[2].Patients.Add(patients[14]);
        rooms[3].Patients.Add(patients[5]);
        rooms[3].Patients.Add(patients[3]);
        rooms[4].Patients.Add(patients[4]);
        rooms[4].Patients.Add(patients[11]);
        rooms[5].Patients.Add(patients[7]);
        rooms[7].Patients.Add(patients[15]);
        rooms[8].Patients.Add(patients[9]);
        rooms[8].Patients.Add(patients[10]);

        return patients;
    }

    public List<Room> SeedRooms()
    {
        var rooms = new List<Room>
        {
            new Room
            {
                Id = 1,
                Name = "Room 1",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 2,
                Name = "Room 2",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 3,
                Name = "Room 3",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 4,
                Name = "Room 4",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 5,
                Name = "Room 5",
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
                Name = "Room 7",
                Patients = new List<Patient>()
            },
            new Room
            {
                Id = 8,
                Name = "Room 8",
                Patients = new List<Patient>()
            },
        };
        return rooms;
    }
}
