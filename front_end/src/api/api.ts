import { Address, Doctor, Patient, Room } from "../models/types";

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
export const doctorsAPI = async (): Promise<Doctor[] | undefined> => {
  try {
    const response = await fetch(URL + "doctors", {
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
export const roomsAPI = async (): Promise<Room[] | undefined> => {
  try {
    const response = await fetch(URL + "rooms", {
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
export const addressAPI = async (): Promise<Address[] | undefined> => {
  try {
    const response = await fetch(URL + "addresses", {
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
