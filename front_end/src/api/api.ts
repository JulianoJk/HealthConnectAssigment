import { Patient } from "../models/types";

const URL = "http://localhost:3001/";

export const patientsAPI = async (): Promise<Patient[] | undefined> => {
  try {
    const response = await fetch(URL + "patients", {
      method: "GET",
      headers: {
        "Content-Type": "application/json",
        "Access-Control-Allow-Origin": "*",
      },
    });
    const data = await response.json();
    return data;
  } catch (error) {
    console.error(error);
  }
};
