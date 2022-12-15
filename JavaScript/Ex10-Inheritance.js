//Inheritance is a feature of OOP where U can extend the functionalities of one class into an other. It is based on the Principle of OOP called as Open-Closed Principle. A Class is closed for modification but open for extension. 
//New syntax of ES6 where we can create class like an Expression.
//Methods of the base class can be reimplemented in the derived class with the following rules: U cannot modify the parameters of the method. It should have the same method signature in the derived class.
//to refer the base class, u can use keyword called super(). super is the way to refer the immediate base class. Earlier versions of JS used base or prototype to refer the immediate base class. 
//Dont use Lambda Methods for overriding the methods as they are scoped only to the class it is created. So no overriding occurs. However, U could use the class methods to achieve the method overriding feature. 
const BaseClass = class{
    data1 = "SomeValue";
    data2 = 2000;

    constructor(){
        console.log("Base class is one that extends to another");
    }

    toString() {
        return `${this.data1} and ${this.data2}`;
    }

    display = () => console.log("Base class Function");
}

class DerivedClass extends BaseClass{
    data3 = true;
    
    displayAnother = () => console.log(this);

    //reimplement the base method: method overriding....
    toString(){
        let data = super.toString();
        data += this.data3; 
        return data;
    }
}

const data = new DerivedClass();
data.display();//From the base class
data.displayAnother();//From the derived class. 
console.log(data.toString()); 