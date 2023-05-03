import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Doctor } from "../../models/types";
import { doctorsAPI } from "../../api/api";
import { Loader } from "@mantine/core";
import { DoctorsTable } from "./DoctorsTable";

const DoctorsComponent = () => {
  const [doctors, setDoctors] = useState<Doctor[]>([]);
  const [openDoctorsTable, setOpenDoctorsTable] = useState<boolean>(false);
  const {
    data: doctorsData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getDoctors"],
    queryFn: async () => {
      const results = await doctorsAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setDoctors(doctorsData as Doctor[]);
      setOpenDoctorsTable(true);
    }
  }, [doctorsData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openDoctorsTable === true ? (
        !doctors.length ? (
          <h3>No doctors to display</h3>
        ) : (
          <DoctorsTable data={doctors}></DoctorsTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default DoctorsComponent;
