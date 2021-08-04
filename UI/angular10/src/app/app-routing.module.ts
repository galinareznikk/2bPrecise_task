import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { EmployeeComponent }from './employee/employee.component';
import { ShowEmployeeComponent } from './show-employee/show-employee.component';
import { EmployeeDetailsComponent } from './show-employee/employee-details/employee-details.component';
import { EmployeeTaskComponent } from './show-employee/employee-task/employee-task.component';
import { EmployeeSubbordinatesComponent } from './show-employee/employee-subbordinates/employee-subbordinates.component';

const routes: Routes = [
  {path:'employee',component:EmployeeComponent},
  {path:'ShowEmployee',component:ShowEmployeeComponent},
  {path:'EmployeeDetails',component:EmployeeDetailsComponent},
  {path:'EmployeeTask',component:EmployeeTaskComponent},
  {path:'EmployeeSubbordinates',component:EmployeeSubbordinatesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
