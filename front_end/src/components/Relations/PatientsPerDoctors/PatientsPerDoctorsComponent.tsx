import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Loader } from "@mantine/core";
import { patientsPerDoctorAPI } from "../../../api/api";
import { PatientsPerDoctor } from "../../../models/types";
import { PatientsPerDoctorsTable } from "./PatientsPerDoctorsTable";

const PatientsPerDoctorsComponent = () => {
  const [PatientsPerDoctors, setPatientsPerDoctors] = useState<
    PatientsPerDoctor[]
  >([]);
  const [openPatientsPerDoctorsTable, setOpenPatientsPerDoctorsTable] =
    useState<boolean>(false);
  const {
    data: PatientsPerDoctorsData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getPatientsPerDoctors"],
    queryFn: async () => {
      const results = await patientsPerDoctorAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setPatientsPerDoctors(PatientsPerDoctorsData as PatientsPerDoctor[]);
      setOpenPatientsPerDoctorsTable(true);
    }
  }, [PatientsPerDoctorsData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openPatientsPerDoctorsTable === true ? (
        !PatientsPerDoctors.length ? (
          <h3>No PatientsPerDoctors to display</h3>
        ) : (
          <PatientsPerDoctorsTable
            data={PatientsPerDoctors}
          ></PatientsPerDoctorsTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default PatientsPerDoctorsComponent;
