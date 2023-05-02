import { useMutation } from "@tanstack/react-query";
import { useEffect, useState } from "react";

interface Patient {
  key: number;
  Id: number;
  FirstName: string;
  LastName: string;
  Age: number;
  EntryDate: string;
  ExitDate: string;
  Address: string;
  Room: string;
  Doctor: string;
}

const URL = "http://localhost:3001/";

const Demo = () => {
  const [patients, setPatients] = useState<Patient[]>([]);

  const patientsAPI = async (): Promise<Patient[] | undefined> => {
    try {
      const response = await fetch(URL + "patients", {
        method: "GET",
        headers: {
          "Content-Type": "application/json",
          "Access-Control-Allow-Origin": "*",
        },
      });
      const data = await response.json();
      return data;
    } catch (error) {
      console.error(error);
    }
  };

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
          {isLoading && <h3>Loading...</h3>}
          {patients.map((patient) => (
            <tr key={patient.Id}>
              <td>{patient.FirstName}</td>
              <td>{patient.LastName}</td>
              <td>{patient.Age}</td>
              <td>{patient.EntryDate}</td>
              <td>{patient.ExitDate}</td>
              <td>{patient.Address}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Demo;
