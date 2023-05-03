export interface Patient {
  key: number;
  Id: number;
  FirstName: string;
  LastName: string;
  Age: number;
  EntryDate: string;
  ExitDate: string;
  AddressName: string;
  Room: string;
  Doctor: string;
}
export interface Doctor {
  key: number;
  Id: number;
  FirstName: string;
  LastName: string;
  Age: number;
  Salary: number;
  PatientNames: string[];
}
export interface Room {
  key: number;
  Id: number;
  Name: string;
  PatientNames: string[];
}
