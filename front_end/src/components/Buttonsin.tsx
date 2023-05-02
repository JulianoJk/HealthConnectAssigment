import { useState } from "react";
import { useMutation } from "@tanstack/react-query";
import './Demo.css'
type Patient = {
  firstName: string;
  lastName: string;
  age: number;
  entryDate: string;
  exitDate: string;
  addressName: string;
  roomName: string;
  doctorName: string;
};

type Doctor = {
  id: number;
  firstName: string;
  lastName: string;
  age: number;
  salary: number;
  patients: Patient[];
};

type Address = {
  id: number;
  name: string;
  country: string;
  city: string;
  postalCode: string;
  patients: Patient[];
};

const Buttonsin = () => {
  const [patients, setPatients] = useState<Patient[]>([]);
  const [doctors, setDoctors] = useState<Doctor[]>([]);
  const [addresses, setAddresses] = useState<Address[]>([]);

  const { mutate: mutatePatients } = useMutation(() =>
    fetch("/patients").then((res) => res.json())
  );

  const { mutate: mutateDoctors } = useMutation(() =>
    fetch("/doctors").then((res) => res.json())
  );

  const { mutate: mutateAddresses } = useMutation(() =>
    fetch("/addresses").then((res) => res.json())
  );

  const handleGetPatientsClick = async () => {
    const { data }: any = await mutatePatients();
    setPatients(data);
  };

  const handleGetDoctorsClick = async () => {
    const { data }: any = await mutateDoctors();
    setDoctors(data);
  };

  const handleGetAddressesClick = async () => {
    const { data }: any = await mutateAddresses();
    setAddresses(data);
  };

  return (
    <div>
      <button onClick={handleGetPatientsClick}>Get Patients</button>
      <button onClick={handleGetDoctorsClick}>Get Doctors</button>
      <button onClick={handleGetAddressesClick}>Get Addresses</button>

      <h2>Patients</h2>
      <ul>
        {patients.map((patient) => (
          <li key={patient.firstName + patient.lastName}>
            {patient.firstName} {patient.lastName}
          </li>
        ))}
      </ul>
      <h2>Doctors</h2>
      <ul>
        {doctors.map((doctor) => (
          <li key={doctor.id}>
            {doctor.firstName} {doctor.lastName}
          </li>
        ))}
      </ul>

      <h2>Addresses</h2>
      <ul>
        {addresses.map((address) => (
          <li key={address.id}>{address.name}</li>
        ))}
      </ul>
    </div>
  );
};

export default Buttonsin;
