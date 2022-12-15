class Employee{
    constructor(id, name, address, salary){
        this.empId = id;
        this.empName = name;
        this.empAddress = address;
        this.empSalary = salary
    }
  }

  class EmpRepo{
      //create an array object. 
      records = [];

      addEmployee(emp){
        this.records.push(emp)
      }

      getAllEmployees = () => this.records;

      getEmployee(id){
          for(const emp of this.records){
              if(emp.empId == id)
                return emp;
          }
          throw `Employee by ID ${id} not found`;
      }

  }

  /////////////////////Testing part//////////////////
  let instance = new EmpRepo();
  instance.addEmployee(new Employee(123, "TestName1", "TestAddress1", 4500));
  instance.addEmployee(new Employee(124, "TestName2", "TestAddress2", 4500));
  instance.addEmployee(new Employee(125, "TestName3", "TestAddress3", 4500));
  instance.addEmployee(new Employee(126, "TestName4", "TestAddress4", 4500));

  const data = instance.getAllEmployees()
  for(const emp of data) console.log(emp.empName);