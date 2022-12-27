//Variables are created using var or let. let is the most prefered way of declaring local variables in JS. 
let value1 = 123; //Variables dont have data type while declaring. 
let value2 = 234;
let result = value1 + value2;

let currentValue = 123;
document.write("The Data Type " + typeof(currentValue)) + "<br/>";

currentValue = "Sample Content";
document.write("The Data Type " + typeof(currentValue)) + "<br/>";

currentValue = true;
document.write("The Data Type " + typeof(currentValue)) + "<br/>";

currentValue = [123,234,43,456];
document.write("The Data Type " + typeof(currentValue)) + "<br/>";

let undefinedVal;
document.write("The Data Type " + typeof(undefinedVal)) + "<br/>";
document.write(result);//Function to write on the HTML document.