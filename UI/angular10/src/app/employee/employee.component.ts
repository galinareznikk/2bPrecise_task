import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service'
import{Router} from '@angular/router'

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(private service:SharedService,private router:Router) { }

  employeeList:any=[]  

  ngOnInit(): void {
    this.showEmployeeList();
  }

showEmployeeList(){
  this.service.getEmpolyeeList().subscribe(data=>
    {
      this.employeeList=data;
    });}

    goToPage(pageName:string):void{
  this.router.navigate([`${pageName}`]);
}

}
