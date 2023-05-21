import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { IPatientPerRoom } from "../../../models/types";
import { patientsPerRoomAPI } from "../../../api/api";
import { Loader } from "@mantine/core";
import { PatientsPerRoomTable } from "./PatientPerRoomTable";

const PatientsPerRoomComponent = () => {
  const [rooms, setRooms] = useState<IPatientPerRoom[]>([]);
  const [openRoomTable, setOpenRoomTable] = useState<boolean>(false);
  const {
    data: patientsPerRoomData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getPatiensPerRooms"],
    queryFn: async () => {
      const results = await patientsPerRoomAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setRooms(patientsPerRoomData as IPatientPerRoom[]);
      setOpenRoomTable(true);
    }
  }, [patientsPerRoomData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openRoomTable === true ? (
        !rooms.length ? (
          <h3>No rooms to display</h3>
        ) : (
          <PatientsPerRoomTable data={rooms}></PatientsPerRoomTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default PatientsPerRoomComponent;
