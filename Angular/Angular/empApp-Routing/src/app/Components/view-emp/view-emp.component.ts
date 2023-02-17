import { Component, OnInit } from '@angular/core';
import { Employee } from '../../Models/employee';
import { EmployeeService } from '../../Services/employee.service';
import { ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit{
  // 2 injectors: service, route
  empId : string | null = ""; //store the id 
  foundEmp : Employee = {} as Employee;
  
  constructor(private service : EmployeeService, private activatedRoute : ActivatedRoute) {
    
  }
  ngOnInit(): void {
   this.activatedRoute.paramMap.subscribe((param: ParamMap) =>{
     this.empId = param.get("id");
   })
   if(this.empId != null){
     this.service.getEmployee(this.empId).subscribe((data : Employee)=>{
       this.foundEmp = data;
     }) 
   } 
  }
}
