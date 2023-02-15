import { Component, OnInit } from '@angular/core';
import { Employee } from '../../Models/employee';


@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.css']
})
export class MasterComponent implements OnInit {
  toShow : number = 0;
  btnMessage : string ="Add Employee";
  employees : Employee[] = [];
selectedEmp : Employee = {} as Employee;

  // API for initializing the data or injecting the data into the Component. 
  ngOnInit(): void {
    this.employees.push({ id: 123, Name:"Vignesh", Address:"Chennai",  Pic:"./assets/images/Vignesh.jfif" , Salary:65000});
    this.employees.push({ id: 124, Name:"Sanjay Sahu", Address:"Hyderabad", Pic:"./assets/images/SanjaySahu.jfif" , Salary:55000});
    this.employees.push({ id: 125, Name:"Shubam Singh", Address:"Varanasi", Pic:"./assets/images/ShubhamSingh.jfif" , Salary:65000});
    this.employees.push({ id: 126, Name:"Sumana", Address:"Bangalore", Pic:"./assets/images/Sumana.jfif" , Salary:75000});
    this.employees.push({ id: 127, Name:"Savitri", Address:"Pune", Pic:"./assets/images/Savitri.jfif" , Salary:34000});
    this.employees.push({ id: 128, Name:"David", Address:"Solna",Pic:"./assets/images/David.jfif" , Salary:72000});
    this.employees.push({ id: 129, Name:"Sereena Williams", Address:"New York", Pic:"./assets/images/Sareena.jfif" , Salary:65000});
    this.employees.push({ id: 130, Name:"Anushka Sharma", Address:"Bangalore", Pic:"./assets/images/Anushka.jfif" , Salary:65000});
  }
    //for selecting the Employee....
    onEdit(emp: Employee){
      this.selectedEmp = emp;
    }

    onDeleteHandler(emp : Employee){
      debugger;
      let index = this.employees.indexOf(emp);
      this.employees.splice(index, 1);
    }

    onAddHandler(emp : Employee){
      this.employees.push(emp);
      this.employees = this.employees.slice();
    }

    onShow(){
      this.toShow =  this.toShow === 0 ? 1 : 0;
      if(this.toShow == 1)
        this.btnMessage = "Cancel Adding";
        else this.btnMessage = "Add Employee";
    }
}
