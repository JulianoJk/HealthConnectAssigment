using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using HealthConnect.Model;

public class Hospital
{
    private List<Patient> patients;
    private List<Address> addresses;
    private List<Room> rooms;
    private List<Doctor> doctors;

    public Hospital()
    {
        addresses = new DataSeeder().SeedAddresses();
        rooms = new DataSeeder().SeedRooms();
        doctors = new DataSeeder().SeedDoctors(patients);
        patients = new DataSeeder().SeedPatients(addresses, rooms, doctors);

        // Update the patients list on the other lists
        foreach (var patient in patients)
        {
            patient.Address.Patients.Add(patient);
            patient.Room.Patients.Add(patient);
            patient.Doctor.Patients.Add(patient);
        }
    }

    public string GetAllPatientsJson()
    {
        List<object> patientList = new();

        foreach (Patient patient in patients)
        {
            var patientObject = new
            {
                patient.Id,
                patient.FirstName,
                patient.LastName,
                patient.Age,
                patient.EntryDate,
                patient.ExitDate,
                AddressName = patient.Address.Name,
                RoomName = patient.Room.Name,
                DoctorName = patient.Doctor.FirstName + " " + patient.Doctor.LastName
            };

            patientList.Add(patientObject);
        }

        return JsonSerializer.Serialize(patientList);
    }

    public string GetAllDoctorsJson()
    {
        List<object> doctorList = new();

        foreach (Doctor doctor in doctors)
        {
            var doctorObject = new
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Age = doctor.Age,
                Salary = doctor.Salary,
                PatientNames = doctor.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            doctorList.Add(doctorObject);
        }

        return JsonSerializer.Serialize(doctorList);
    }

    public string GetAllAddressesJson()
    {
        List<object> addressList = new();

        foreach (Address address in addresses)
        {
            var addressObject = new
            {
                Name = address.Name,
                Country = address.Country,
                City = address.City,
                PostalCode = address.PostalCode,
                PatientNames = address.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            addressList.Add(addressObject);
        }

        return JsonSerializer.Serialize(addressList);
    }

    public string GetAllRoomsJson()
    {
        List<object> roomList = new();

        foreach (Room room in rooms)
        {
            var roomObject = new
            {
                Name = room.Name,
                PatientNames = room.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            roomList.Add(roomObject);
        }

        return JsonSerializer.Serialize(roomList);
    }

    public string GetAllPatientsPerRoomJson()
    {
        List<object> patientsPerRoomList = new();

        foreach (Room room in rooms)
        {
            var patientsPerRoomObject = new
            {
                RoomName = room.Name,
                PatientNames = room.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            patientsPerRoomList.Add(patientsPerRoomObject);
        }

        return JsonSerializer.Serialize(patientsPerRoomList);
    }

    public string GetAllPatientsPerDoctorJson()
    {
        List<object> patientsPerDoctorList = new();

        foreach (Doctor doctor in doctors)
        {
            var patientsPerDoctorObject = new
            {
                DoctorName = doctor.FirstName + " " + doctor.LastName,
                PatientNames = doctor.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            patientsPerDoctorList.Add(patientsPerDoctorObject);
        }

        return JsonSerializer.Serialize(patientsPerDoctorList);
    }

    public string GetAllPatientsPerAddressJson()
    {
        List<object> patientsPerAddressList = new();

        foreach (Address address in addresses)
        {
            var patientsPerAddressObject = new
            {
                AddressName = address.Name,
                PatientNames = address.Patients.Select(p => p.FirstName + " " + p.LastName).ToList()
            };

            patientsPerAddressList.Add(patientsPerAddressObject);
        }

        return JsonSerializer.Serialize(patientsPerAddressList);
    }

    public string GetAllAddressesPerPatientJson()
    {
        List<object> addressesPerPatientList = new();

        foreach (Patient patient in patients)
        {
            var addressesPerPatientObject = new
            {
                PatientName = patient.FirstName + " " + patient.LastName,
                AddressName = patient.Address.Name
            };

            addressesPerPatientList.Add(addressesPerPatientObject);
        }

        return JsonSerializer.Serialize(addressesPerPatientList);
    }
}
