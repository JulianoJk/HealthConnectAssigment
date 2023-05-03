import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";

import { HeaderResponsive } from "./components/header/HeaderResponsive";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import PatientsComponent from "./components/Patients/PatientsComponent";
import DoctorsComponent from "./components/Doctors/DoctorsComponent";
import RoomComponent from "./components/Rooms/RoomsComponent";
import AddressComponent from "./components/Address/AddressComponent";

export default function App() {
  const queryClient = new QueryClient();

  return (
    <QueryClientProvider client={queryClient}>
      <ReactQueryDevtools initialIsOpen={false} />

      <BrowserRouter>
        <HeaderResponsive
          links={[
            {
              link: "/",
              label: "Patients",
            },
            {
              link: "/doctors",
              label: "Doctors",
            },
            {
              link: "/rooms",
              label: "Rooms",
            },
            {
              link: "/address",
              label: "Address",
            },
          ]}
        />
        <Routes>
          <Route path="/" element={<PatientsComponent />} />
          <Route path="/doctors" element={<DoctorsComponent />} />
          <Route path="/rooms" element={<RoomComponent />} />
          <Route path="/address" element={<AddressComponent />} />
          <Route path="/*" element={<PatientsComponent />} />
        </Routes>
      </BrowserRouter>
    </QueryClientProvider>
  );
}
