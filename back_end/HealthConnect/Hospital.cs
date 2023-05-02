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
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    Age = patient.Age,
                    EntryDate = patient.EntryDate,
                    ExitDate = patient.ExitDate,
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
    }


