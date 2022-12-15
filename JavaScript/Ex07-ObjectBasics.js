let obj = {};//creates an object. 
obj.id = 123;
obj.name = "testName";
obj.address = "testAddress";
obj.salary = 45000;

for(const key in obj) console.log(obj[key]);

//To display the object in JSON format we can use JSON.stringify
console.log(JSON.stringify(obj));

////////////////////////Using Class keyword/////////////////////
//Using class, we can create a prototype and then create objects for that prototype. The Prototype is called as Class and the object is called as the instance of the class. 
//Class is a User defined Data Type(UDT). This type can have fields, functions, properties. 
//To create objects, we use constructor with a keyword called constructor. 

class Employee{
  constructor(id, name, address, salary){
      this.empId = id;
      this.empName = name;
      this.empAddress = address;
      this.empSalary = salary
  }
}

const empObj = new Employee(123, "Phaniraj", "Bangalore", 89000);