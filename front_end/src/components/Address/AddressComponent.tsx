import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";

import { addressAPI } from "../../api/api";
import { Loader } from "@mantine/core";
import { Address } from "../../models/types";
import { AddressTable } from "./AddressTable";

const AddressComponent = () => {
  const [adresses, setAddresses] = useState<Address[]>([]);
  const [openAddressTable, setOpenAddressTable] = useState<boolean>(false);
  const {
    data: addressData,
    isLoading,
    status,
  } = useQuery({
    queryKey: ["getAddress"],
    queryFn: async () => {
      const results = await addressAPI();
      return results;
    },
  });
  useEffect(() => {
    if (status === "success") {
      setAddresses(addressData as Address[]);
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
          <AddressTable data={adresses}></AddressTable>
        )
      ) : (
        <></>
      )}
    </>
  );
};

export default AddressComponent;
