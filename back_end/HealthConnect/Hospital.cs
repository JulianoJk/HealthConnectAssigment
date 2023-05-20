using System.Text.Json;
using HealthConnect.Model;

public class Hospital
{
    private readonly List<Patient> _patients;
    private readonly List<Doctor> _doctors;
    private readonly List<Address> _addresses;
    private readonly List<Room> _rooms;

    public Hospital()
    {
        DataSeeder dataSeeder = new();
        _addresses = dataSeeder.SeedAddresses();
        _rooms = dataSeeder.SeedRooms();
        _doctors = dataSeeder.SeedDoctors();
        _patients = dataSeeder.SeedPatients(_addresses, _rooms, _doctors);
    }

    public string GetPatientsJson()
    {
        List<object> patientList = new();

        foreach (Patient patient in _patients)
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

    public string GetDoctorsJson()
    {
        List<object> doctorList = new();

        foreach (Doctor doctor in _doctors)
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

    public string GetAddressesJson()
    {
        List<object> addressList = new();

        foreach (Address address in _addresses)
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

    public string GetRoomsJson()
    {
        List<object> roomList = new();

        foreach (Room room in _rooms)
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

    public string GetPatientsPerRoomJson()
    {
        List<object> patientsPerRoomList = new();

        foreach (Room room in _rooms)
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

    public string GetPatientsPerDoctorJson()
    {
        List<object> patientsPerDoctorList = new();

        foreach (Doctor doctor in _doctors)
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

    public string GetPatientsPerAddressJson()
    {
        List<object> patientsPerAddressList = new();

        foreach (Address address in _addresses)
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

    public string GetAddressPerPatientJson()
    {
        List<object> addressPerPatientList = new();

        foreach (Patient patient in _patients)
        {
            var addressPerPatientObject = new
            {
                PatientName = patient.FirstName + " " + patient.LastName,
                AddressName = patient.Address.Name
            };

            addressPerPatientList.Add(addressPerPatientObject);
        }

        return JsonSerializer.Serialize(addressPerPatientList);
    }
}
