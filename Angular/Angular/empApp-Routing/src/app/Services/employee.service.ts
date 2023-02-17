import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Employee } from '../Models/employee';
import { Observable } from 'rxjs';

@Injectable({providedIn: 'root'})
export class EmployeeService {
  url : string ="http://localhost:3000/employees"

  constructor(private httpClient: HttpClient) { }

  public getAllEmployees(): Observable<Employee[]>{
    return this.httpClient.get<Employee[]>(this.url);
  }

  public getEmployee(id: string) : Observable<Employee>{
    const temp : string = this.url + "/" + id;
    return this.httpClient.get<Employee>(temp);
  }

  public postEmployee(emp : Employee) :Observable<Employee>{
    return this.httpClient.post<Employee>(this.url, emp);
  }

  public deleteEmployee(id: string):Observable<any>{
    debugger;
    const temp : string = this.url + "/" + id;
    return this.httpClient.delete(temp);
  }

  public putEmployee(id : string, emp : Employee)  : Observable<Employee>{
    const temp : string = this.url + "/" + id;
    return this.httpClient.put<Employee>(temp, emp);
  }
}
