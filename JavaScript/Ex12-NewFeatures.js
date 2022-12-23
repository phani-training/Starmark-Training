/*
- let keyword and const are the new ways of creating data in JS.
- const is used for refering data that does not modify over the course of time. 
- let allows to create variables that are scope based. 
- Earlier, we used another way called as var. 
- var is function based whereas let is scope based. There are only 2 scopes in var: one is global and another is function based. 
- var adds to the global scope but let does not.  
- var gets hoisted itself to the upper scope which let does not. 
- var allows redeclaration within the same scope which is not allowed in let. 
- var has automatic initialization but let does not have.
*/

//////////////////First Example/////////////////////////////////////////
var example = 123;//This variable is added to the Window object of the browser. If it is in Nodejs, then it will be added to global object. 
let letExample = 234;
console.log(window.example);
console.log(window.letExample);
//////////////////Second Example for Hoisting//////////////////////////
for(var i = 0; i < 5; i++){
    console.log(i);
}
console.log(i);//Gives an error when let is used.

////////////////////////Third Example for redeclaration////////////////////
function testFunc(){
    let example = 234;
    //let example ="Appl213";
    console.log(example);
}
////////////////////////////4th Example on Automatic intialization/////
//var data;
//console.log(data);//with var it does not give error, but with let it gives reference Exception saying that U R accessing the uninitialized let variable. 
//let data;

///////////////////////////////////////////////////////////////////////////////
/////////////////////Default Parameters in JS//////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/*
Parameters is what U define in the function. Arguements is what U pass to the function while calling it. 
 */
function sampleFunc(message = "Good Morning") {
    console.log(message);
}

sampleFunc();
sampleFunc("Sample Text");

function createDiv(height = '350px', width = '45%', display ='inline-block', border = '1px solid red'){
    const div = document.createElement("div");
    div.style.height = height;
    div.style.width = width;
    div.style.display = display;
    div.style.border = border;
    
    const area = document.querySelector("#divArea");
    area.appendChild(div);
    return div;
}
///////////////////////////////////////////////////////////////////////////////
/////////////////////rest Parameters in JS/////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/*
#### rest parameters:
- Used to set variable no of arguements.
- Rest parameter is created using ... operator. 
- U can have normal parameters in UR function. The Rest parameter should be the last of the parameter list. 
- The Rest parameter is always an array. 
*/

//How to add only numbers, rest should be ignored...
function add(... args){
    // let res = 0;
    // for(const val of args) 
    //     res += val;
    // return res;

    return args
        .filter((e) => typeof e === 'number')
        .reduce((prev, next) => prev + next);
}
console.log(add(123,23));
console.log(add(123,23,45,56));
console.log(add(123,23,67,89,89,77,66));
console.log(add("Testing", true, 34, 45.56, "Sample", {"data" : 123}))


///////////////////////////////////////////////////////////////////////////////
/////////////////////Spread Parameters in JS/////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
 
const values = [1,2,3,4];//it could be an array, map or set..
const newValues = [0, ...values];
console.log(newValues);

const data = [];
const states = ["kar", "AP", "Tg", "Tn"];
const northStates = [ "Up", "Bh", "Jk", "Del"];
const indianStates = [...states, ...northStates];
states.push(...northStates);
console.log(states);
console.log(indianStates);
///////////////////////////////////////////////////////////////////////////////
/////////////////////Static Methods in JS//////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/*
#### Static methods in a class. 
- Static methods are methods that are invoked by the name of the class instead of object of it. 
- We use static methods when we want to call the method across multiple places within the application, so that there need to be frequent object creations while we call them.
- creating static methods and fields were introduced in ES 7 of JS. 
- U can call the static method inside a non static method of the same class using this.constructor. But on the reverse, U can call by creating the instance of the class. 
 */
class MathExample{
    //static function
    static addFunc = (v1, v2) => v1 + v2;
 
    //instance function
    callStaticFunc(){
        this.constructor.addFunc(123, 234);
    }
}

console.log(MathExample.addFunc(123, 234));  

const obj = new MathExample();
obj.callStaticFunc();

