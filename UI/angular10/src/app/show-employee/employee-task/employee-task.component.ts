import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-employee-task',
  templateUrl: './employee-task.component.html',
  styleUrls: ['./employee-task.component.css']
})
export class EmployeeTaskComponent implements OnInit {

  constructor(private service:SharedService) { }

  taskList:any=[];

  ngOnInit(): void {
    this.getTasks();
  }

  getTasks(){
    this.service.getTasksList().subscribe(data=>{
      this.taskList=data;

  })
}


}
