import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
 //members of the Component:
 
 value1 : number = 123;
 value2 : number = 234;
 result : number = this.value1 + this.value2;


 
 //Functions of the Component...
 onClick = ()=>{
   alert("This is a function in typescript");
 }

 onAddFunc(){
   this.value1 = Number(prompt("Enter the First Value"));
   this.value2 = Number(prompt("Enter the second Value"));
   this.result = this.value1 + this.value2;
 }
}
