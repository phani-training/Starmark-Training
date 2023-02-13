import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent {
  value1 : number = 123.0;
  value2 : number = 0.0;
  operand : string = "";
  result : number = 0.0;

  onSubmit(){
    debugger;
    switch (this.operand) {
      case "+":
        this.result = this.value1 + this.value2;
        break;
      case "-":
        this.result = this.value1 - this.value2;
        break;
      case "X":
        this.result = this.value1 * this.value2;
        break;
      case "/":
        this.result = this.value1 / this.value2;
        break;
    }
  }
}
