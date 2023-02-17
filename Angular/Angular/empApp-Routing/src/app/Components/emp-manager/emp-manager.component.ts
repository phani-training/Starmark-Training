import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../Services/employee.service';
import { Employee } from '../../Models/employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-emp-manager',
  templateUrl: './emp-manager.component.html',
  styleUrls: ['./emp-manager.component.css']
})
export class EmpManagerComponent implements OnInit {
  empList: Employee[] = []; 
  constructor(private service : EmployeeService, private router : Router) {
    
  }

  getDataFromServer() {
    let observable = this.service.getAllEmployees();
    observable.subscribe((data: Employee[]) => {
      this.empList = data;
    })
  }
  ngOnInit(): void {
    this.getDataFromServer();
  }

  onDelete(id: number) {
    this.service.deleteEmployee(id.toString()).subscribe((data: any) => {
      alert(data);
      this.getDataFromServer();
    });
  }
}
