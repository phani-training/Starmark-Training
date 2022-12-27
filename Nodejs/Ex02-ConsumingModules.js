const myModule = require("./CustomModule");//Import the module
const aliasFunc = myModule.simpleFunc;//Reference of the function
const mathTable = myModule.mathTable;//Reference of the function
const empClass = myModule.employee;//Reference of the Class
aliasFunc();

myModule.simpleFunc();

mathTable(3);

const empObj = new empClass(123, "Phaniraj", "Bangalore");
empObj.display();