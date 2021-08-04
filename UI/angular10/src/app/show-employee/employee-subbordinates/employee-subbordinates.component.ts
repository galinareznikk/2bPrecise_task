import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service'

@Component({
  selector: 'app-employee-subbordinates',
  templateUrl: './employee-subbordinates.component.html',
  styleUrls: ['./employee-subbordinates.component.css']
})
export class EmployeeSubbordinatesComponent implements OnInit {

  constructor(private service:SharedService) { }

  ngOnInit(): void {
    this.getSubordinates();
  }

  subordinatesList:any=[]  

  getSubordinates(){
    this.service.getSubordinates().subscribe(data=>
      {
        this.subordinatesList=data;
      });
  }


}
