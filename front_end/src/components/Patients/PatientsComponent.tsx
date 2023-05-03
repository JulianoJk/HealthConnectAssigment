import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Patient } from "../../models/types";
import { patientsAPI } from "../../api/api";
import { Loader } from "@mantine/core";
import { PatientsTable } from "./PatientsTable";
const PatientsComponent = () => {
  const [patients, setPatients] = useState<Patient[]>([]);
  const [openPatientsTable, setOpenPatientsTable] = useState<boolean>(false);

  const {
    data: patientsData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getPatients"],
    queryFn: async () => {
      const results = await patientsAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setPatients(patientsData as Patient[]);
      setOpenPatientsTable(true);
    }
  }, [patientsData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openPatientsTable === true ? (
        !patients.length ? (
          <h3>No patients to display</h3>
        ) : (
          <PatientsTable data={patients}></PatientsTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default PatientsComponent;
