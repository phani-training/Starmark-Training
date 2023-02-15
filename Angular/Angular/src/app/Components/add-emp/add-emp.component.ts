import { Component, EventEmitter, Output } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-add-emp',
  templateUrl: './add-emp.component.html',
  styleUrls: ['./add-emp.component.css']
})
export class AddEmpComponent {
  empId : number = 0;
  empName : string = "";
  empAddress : string ="";
  empImg : string ="";
  empSalary : number = 0;
  @Output() onAddNew : EventEmitter<Employee> = new EventEmitter<Employee>();
  
  onInvokeFunc(){
    const emp = {} as Employee;
    emp.id = this.empId;
    emp.Name = this.empName;
    emp.Address = this.empAddress;
    emp.Pic = this.empImg;
    emp.Salary = this.empSalary;
    this.onAddNew.emit(emp);
    this.clearFields();
  }

  clearFields(){
    this.empId = 0;
    this.empName = "";
    this.empAddress = "";
    this.empSalary = 0;
    this.empImg = "";
  }
}
