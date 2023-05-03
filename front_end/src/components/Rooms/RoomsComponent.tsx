import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Room } from "../../models/types";
import { roomsAPI } from "../../api/api";
import { Loader } from "@mantine/core";
import { RoomTable } from "./RoomTable";

const RoomComponent = () => {
  const [rooms, setRooms] = useState<Room[]>([]);
  const [openRoomTable, setOpenRoomTable] = useState<boolean>(false);
  const {
    data: roomData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getRooms"],
    queryFn: async () => {
      const results = await roomsAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setRooms(roomData as Room[]);
      setOpenRoomTable(true);
    }
  }, [roomData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openRoomTable === true ? (
        !rooms.length ? (
          <h3>No rooms to display</h3>
        ) : (
          <RoomTable data={rooms}></RoomTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default RoomComponent;
