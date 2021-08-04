import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl='https://localhost:44319/api';
  constructor(private http:HttpClient) { }

   getEmpolyeeList():Observable<any[]>{
     return this.http.get<any> (this.APIUrl+'/getEmpolyeeList');
   }

   getTasksList():Observable<any[]>{
    return this.http.get<any> (this.APIUrl+'/getTasksList');

   }

   getSubordinates():Observable<any[]>{
    return this.http.get<any> (this.APIUrl+'/getSubordinates');
   }

   getManagerFullName():Observable<any[]>{
    return this.http.get<any> (this.APIUrl+'/getManagerFullName');

   }


   getEmployeeDtails():Observable<any[]>{
    return this.http.get<any> (this.APIUrl+'/getEmployeeDtails');

   }







}
