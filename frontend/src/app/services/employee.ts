import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Employee {
  id: number;
  username: string;
  phone: string;
  city: string;
  country: string;
  photoUrl: string;
  patients: Patient[];
  lastActive: string;
}

export interface Patient {
  id: number;
  name: string;
  dateOfBirth: string;
  lastActive?: string;
  departmentId?: number;
  photoUrl: string;
}

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private baseUrl = 'http://localhost:5000/api/Employees';

  constructor(private http: HttpClient) {}

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.baseUrl);
  }

  getEmployee(id: number): Observable<Employee> {
    return this.http.get<Employee>(`${this.baseUrl}/${id}`);
  }
}
