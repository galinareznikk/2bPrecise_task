import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  constructor(private service:SharedService) { }

  managerData:any=[];
  employeeData:any=[];

  ngOnInit(): void {
    this.getMangerData();
    this.getEmployeeData();
  }

  getMangerData(){
    this.service.getManagerFullName().subscribe(data=>{
      this.managerData=data;
    })
  }
  getEmployeeData(){
    this.service.getEmployeeDtails().subscribe(data=>{
      this.employeeData=data;
    })
  }


}
