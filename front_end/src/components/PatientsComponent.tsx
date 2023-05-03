import { useMutation } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Patient } from "../models/types";
import { patientsAPI } from "../api/api";
import { Loader } from "@mantine/core";
import { PatientsTable } from "./PatientsTable";
const PatientsComponent = () => {
  const [patients, setPatients] = useState<Patient[]>([]);
  const [openPatientsTable, setOpenPatientsTable] = useState<boolean>(false);

  const { mutate: mutatePatients, isLoading } = useMutation(patientsAPI, {
    onSuccess: (data) => {
      if (data !== undefined) {
        setPatients(data);
      }
    },
  });

  const handleGetPatientsClick = async () => {
    setOpenPatientsTable(!openPatientsTable);
    await mutatePatients();
  };
  // use effect to console.log openPatientsTable everytime the value changes
  useEffect(() => {
    console.log(openPatientsTable);
  }, [openPatientsTable]);

  return (
    <div>
      <h1>Patients</h1>
      <button onClick={handleGetPatientsClick}>
        {!openPatientsTable ? "Get Patients" : "Close table"}
      </button>
      {isLoading && <Loader size="xl" />}
      {openPatientsTable === true ? (
        !patients.length ? (
          <h3>No patients to display</h3>
        ) : (
          <PatientsTable data={patients}></PatientsTable>
        )
      ) : (
        <></>
      )}
    </div>
  );
};

export default PatientsComponent;
