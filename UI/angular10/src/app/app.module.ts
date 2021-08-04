import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';

import { EmployeeComponent } from './employee/employee.component';

import { ShowEmployeeComponent } from './show-employee/show-employee.component';
import { EmployeeDetailsComponent } from './show-employee/employee-details/employee-details.component';
import { EmployeeTaskComponent } from './show-employee/employee-task/employee-task.component';
import { EmployeeSubbordinatesComponent } from './show-employee/employee-subbordinates/employee-subbordinates.component';

import { SharedService } from './shared.service';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule ,ReactiveFormsModule} from '@angular/forms';



@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    ShowEmployeeComponent,
    EmployeeDetailsComponent,
    EmployeeTaskComponent,
    EmployeeSubbordinatesComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
