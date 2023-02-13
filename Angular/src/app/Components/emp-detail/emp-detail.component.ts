import { Component, Input } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-emp-detail',
  templateUrl: './emp-detail.component.html',
  styleUrls: ['./emp-detail.component.css']
})
export class EmpDetailComponent {
  @Input() selectedEmp : Employee = {} as Employee
  //@Input is used to set values to the property from the Outer component or the Parent Component of this Component. 
}
