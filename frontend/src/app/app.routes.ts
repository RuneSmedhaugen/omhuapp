import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { EmployeeDetail } from './pages/employee-detail/employee-detail';

export const routes: Routes = [
  { path: 'home', component: Home },
  { path: 'employee/:id', component: EmployeeDetail },
  { path: '', redirectTo: 'home', pathMatch: 'full' },


];
