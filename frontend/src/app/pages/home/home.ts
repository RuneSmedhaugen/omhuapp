import { Component, OnInit } from '@angular/core';
import { EmployeeService, Employee } from '../../services/employee';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './home.html',
  styleUrls: ['./home.css']
})
export class Home implements OnInit {
  employees: Employee[] = [];
  loading = true;
  error = '';

  constructor(private employeeService: EmployeeService) {}

  ngOnInit(): void {
    this.employeeService.getEmployees().subscribe({
      next: (data) => {
        console.log('API response:', data);
        this.employees = data;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error fetching employees:', err);
        this.error = 'Could not load employees';
        this.loading = false;
      }
    });
  }
}
