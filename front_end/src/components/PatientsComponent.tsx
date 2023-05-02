import { useMutation } from "@tanstack/react-query";
import { useState } from "react";
import { Patient } from "../models/types";
import { patientsAPI } from "../api/api";

const PatientsComponent = () => {
  const [patients, setPatients] = useState<Patient[]>([]);

  const { mutate: mutatePatients, isLoading } = useMutation(patientsAPI, {
    onSuccess: (data) => {
      if (data !== undefined) {
        setPatients(data);
      }
    },
  });

  const handleGetPatientsClick = async () => {
    await mutatePatients();
  };

  return (
    <div>
      <h1>Patients</h1>
      <button onClick={handleGetPatientsClick}>Get Patients</button>
      {isLoading && <h3>Loading...</h3>}
      {!patients.length ? (
        <h3>No patients to display</h3>
      ) : (
        <table>
          <thead>
            <tr>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Age</th>
              <th>Entry Date</th>
              <th>Exit Date</th>
              <th>Address</th>
            </tr>
          </thead>
          <tbody>
            {patients.map((patient) => (
              <tr key={patient.Id}>
                <td>{patient.FirstName}</td>
                <td>{patient.LastName}</td>
                <td>{patient.Age}</td>
                <td>{patient.EntryDate}</td>
                <td>{patient.ExitDate}</td>
                <td>{patient.AddressName}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  );
};

export default PatientsComponent;
