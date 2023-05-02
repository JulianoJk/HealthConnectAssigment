using System;
using System.Collections.Generic;
using HealthConnect.Model;

public class Hospital
{
    public void PrintPatients()
    {
        DataSeeder dataSeeder = new DataSeeder();
        List<Address> addresses = dataSeeder.SeedAddresses();
        List<Room> rooms = dataSeeder.SeedRooms();
        List<Doctor> doctors = dataSeeder.SeedDoctors();
        List<Patient> patients = dataSeeder.SeedPatients(addresses, rooms, doctors);

        Console.WriteLine("Patients");
        Console.WriteLine("First Name\tLast Name\tAge\tEntry Date\tExit Date\tAddress Name\tRoom Name\tDoctor Name");

        foreach (Patient patient in patients)
        {
            Console.WriteLine(
                $"{patient.FirstName}\t{patient.LastName}\t{patient.Age}\t{patient.EntryDate}\t{patient.ExitDate}\t{patient.Address.Name}\t{patient.Room.Name}\t{patient.Doctor.FirstName} {patient.Doctor.LastName}"
            );
            Console.WriteLine("Hello there");
        }

        Console.WriteLine();
    }
    public void PrintDoctors()
    {
        DataSeeder dataSeeder = new DataSeeder();
    }
}
