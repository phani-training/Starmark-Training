let obj = {}//Singleton object: It always represents one and only one object. 
obj.id = 123;
obj.name ="Phaniraj";
obj.address ="Bangalore";
obj.salary = 56000;


let obj2 = obj;
obj2.id = 234;
obj2.name ="TestName";
obj2.address ="TestAddress";
obj2.salary = 77777;



function getObject() {
    return JSON.stringify(obj);
}

/////////////////////////Class creation in JS//////////////////////////
class Employee{ //This is ES6 syntax of creating class.
    constructor(id, name, address, salary){
        this.empId = id;
        this.empName = name;
        this.empAddress = address;
        this.empSalary = salary;
    }
}

const empClass = function(id, name, address, salary){
    this.empId = id;
    this.empName = name;
    this.empAddress = address;
    this.empSalary = salary;
}

const empRec = new Employee(123, "Phaniraj", "Bangalore", 67000);

const empRec2 = new Employee(124, "Vinod Kumar", "Shimoga", 77000);

const empRec3 = new empClass(125, "David", "Pune", 70000);
function returnData(){
    let data = [empRec, empRec2, empRec3];
    return JSON.stringify(data);
}
