import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EmployeeService, Employee } from '../../services/employee';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.html',
  styleUrls: ['./employee-detail.css'],
})
export class EmployeeDetail implements OnInit {
  employee?: Employee;

  constructor(
    private route: ActivatedRoute,
    private employeeService: EmployeeService
  ) {}

  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));

    this.employeeService.getEmployee(id).subscribe((emp) => {
      console.log('Fetched employee:', emp);
      this.employee = emp;
    });
  }

  calculateAge(dateOfBirth: string): number {
    const dob = new Date(dateOfBirth);
    const diffMs = Date.now() - dob.getTime();
    const ageDate = new Date(diffMs);
    return Math.abs(ageDate.getUTCFullYear() - 1970);
  }

  lastActiveDays(lastActive: string): number {
  const last = new Date(lastActive);
  const now = new Date();
  const diffMs = now.getTime() - last.getTime();
  return Math.floor(diffMs / (1000 * 60 * 60 * 24));
}

}
