import { Tabs } from "@mantine/core";
import {
  IconBed,
  IconStethoscope,
  IconMapPin,
  IconMap2,
} from "@tabler/icons-react";
import { useState } from "react";
import PatientsPerRoomTable from "./PatientsPerRoom/PatientsPerRoomComponent";
import PatientPerAddressComponent from "./PatientsPerAddress/PatientPerAddressComponent";
import PatientsPerDoctorsComponent from "./PatientsPerDoctors/PatientsPerDoctorsComponent";

const Relations = () => {
  const [activeTab, setActiveTab] = useState<string | null>("PPR");

  return (
    <>
      <Tabs
        color="cyan"
        variant="pills"
        radius="md"
        orientation="vertical"
        defaultValue="PPR"
        value={activeTab}
        onTabChange={setActiveTab}
      >
        <Tabs.List>
          {/*  Values are the initials of the labels. Patients per Room = PPR, etc.
           */}
          <Tabs.Tab value="PPR" icon={<IconBed size="0.8rem" />}>
            Patients per Room
          </Tabs.Tab>
          <Tabs.Tab value="PPD" icon={<IconStethoscope size="0.8rem" />}>
            Patients per Doctor
          </Tabs.Tab>
          <Tabs.Tab value="PPA" icon={<IconMapPin size="0.8rem" />}>
            Patients per Address
          </Tabs.Tab>
        </Tabs.List>

        <Tabs.Panel value="PPR" pl="xs">
          <PatientsPerRoomTable />
        </Tabs.Panel>

        <Tabs.Panel value="PPD" pl="xs">
          <PatientsPerDoctorsComponent />
        </Tabs.Panel>

        <Tabs.Panel value="PPA" pl="xs">
          <PatientPerAddressComponent />
        </Tabs.Panel>
      </Tabs>
    </>
  );
};
export default Relations;
