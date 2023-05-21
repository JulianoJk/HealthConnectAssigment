import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";
import { Loader } from "@mantine/core";
import { IPatientPerAddress } from "../../../models/types";
import { PatientPerAddressTable } from "./PatientPerAddressTable";
import { patientsPerAddressAPI } from "../../../api/api";

const PatientPerAddressComponent = () => {
  const [adresses, setAddresses] = useState<IPatientPerAddress[]>([]);
  const [openAddressTable, setOpenAddressTable] = useState<boolean>(false);
  const {
    data: addressData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getPatientPerAddress"],
    queryFn: async () => {
      const results = await patientsPerAddressAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setAddresses(addressData as IPatientPerAddress[]);
      setOpenAddressTable(true);
    }
  }, [addressData, status]);

  return (
    <>
      {isLoading && <Loader size="30rem" />}
      {openAddressTable === true ? (
        !adresses.length ? (
          <h3>No addresses to display</h3>
        ) : (
          <PatientPerAddressTable data={adresses}></PatientPerAddressTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default PatientPerAddressComponent;
