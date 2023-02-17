import { Component } from '@angular/core';
import { EmployeeService } from '../../Services/employee.service';
import { Employee } from '../../Models/employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-emp',
  templateUrl: './add-emp.component.html',
  styleUrls: ['./add-emp.component.css']
})
export class AddEmpComponent {
  imgUrl : string  =""; 
  empObj : Employee = {} as Employee;
   constructor(private service : EmployeeService, private router : Router) {
     //router is used for navigation purposes...
   }
   //For file uploading....
   onFileChange(event : any){
    let reader = new FileReader();
    reader.readAsDataURL(event.target.files[0]);
    reader.onload = (_ev)=>{
      this.imgUrl = reader.result as string;
      this.empObj.empPic = this.imgUrl;
    }
   }
   //adding to the Server....
   onAddEmployee(){
     this.service.postEmployee(this.empObj).subscribe((data: Employee)=>{
       this.empObj = data;
       alert("Employee Inserted Successfully")
       this.router.navigate(['/']);
     })
   }
}
