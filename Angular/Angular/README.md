# What is Angular?
Angular is a framework based on JS and TS to create Component based Web Apps that is designed to run on multiple devices and platforms. Developed by Google, it is robust and reliable Framework and easy to work with.
Latest version is 14 released in Apr-22. 

# Constituents of an Angular App:
Angular apps contains one or more modules that are feature centric groups where each module contain one or more components, services, interfaces, classes, pipes and directives. 
Components: UI Components with code, html, css and UT code. 
Services: Functions and singleton objects that can be used across the components of a module.
Interfaces: Contracts and Data Representations.
Directives: Sp interpretations for the HTML code that U create, U can consider it as short cuts to a template code of html.
Pipes: Transformers for the data to be presentable based on the UI logic. 
All the above units are classes  by themselves with directives to define what they are. 

# Sofware for Angular Apps?

Software requirements:
1. Any OS
2. Nodejs and NPM 
3. Angular CLI ==>npm install -g @angular/cli
4. VS Code for IDE. 

## How to create Angular app?
Create a folder for UR App at UR prefered place in UR Machine. 
Open the Cmd and move to the Folder location in the Cmd. 
Run the CLI Command to create a new App => ng new sample-app

## Features of an Angular App:
- It supports Single Page Applications(SPAs). There is only one Page in Angular: index.html
- Dependency Injection. 
- Data Binding, Event Binding and Property Binding. 
- Elegant Routing feature.
- Good Support for REST API Calls
- Handling Async calls using Observables of RxJs.

--------------Services----------------------------
## What is a service in angular?
All data that U work in Components are limited to the components where U create them. So share the data among the components, we use services. Services maintain singleton objects so that we can use them across the app. Where ever U refer it inside the Angular App, it gives the same instance. So if UR AddComponent has added data, U can get the added data in the GetAllComponent also. Ofcourse, U have to get the reference of the service component. 
Services are also required to contact the external REST API that is created to persist the data in the server side like a DB or a file. 
In our example, we will use a service created using json-server, the Nodejs app. 

Create a REST API using json-server. Test it with Post Man. 
Create a service in Angular to access the json-server.
Use the service in our components to perform the required CURD operations. 

## Steps to create json-server:
- create a new folder by name json-restapi. 

- Open the folder in a new instance of VS Code. 

- create a new file called db.json and write sample data in it. 

- Data is shared in the chat box. 

- Make sure U have json-server installed in ur machine. If not:

- npm install -g json-server --save : Run this command from the Cmd. 

- Run the following command to test the server on Port no 9000:  

- json-server --watch db.json -p 9000

- Test the server by opening the browser and run localhost:9000/employees

- Let me know once U R all done with it. 

Create a new Ang App called EmpDataApp <br/>
### Components: 
- ng g c --skip-tests=true Components/compName
- navBar
- empManager
- view-emp
- add-emp
- edit-emp

### Models(Data)
Create a model for the data: 
- ng g i Models/employee
- Model: employee 

## Command to create service:
* ng generate service --skip-tests=true Services/Employee
Create a new Service under the name Employee. This will be used to share the data across the application. 
- Service is a class in Angular with a directive @Injectable which means that it can be inserted into a component using Dependency Injection. The class instance will be injectable across the Application and maintains a single reference of it wherever it is used.
- service gets its data from REST API in our App. To Access REST API, we need to use HTTP services. A module called HttpClientModule provided by Angular contains APIs for accessing REST API using HTTP methods. It must be declared in the App.module.ts file. 

### Pipes in Angular
- Pipes are filters that provide a mechanism to format the data that U want to show to the User interface. It is a class with a directive Pipe and implement an interface called PipeTransform.
 
The PipeTransform has a function to implement called transform that take the following args:
- first: the data for the pipe to transform
- criteria: condition of filter,it could have variable no of args. 
- The function returns the filtered data.

Pipes are not just used for filtering, but also to transform the input content to the format that UR UI has to show it.
- CLI: ng g p --skip-tests=true Pipes/pipeName
## Reactive Forms:
Reactive Forms are also called as Model driven forms and is one of the 2 ways for creating Angular Forms. This helps in creating Tightly bound forms that are directly related to the model data that U R displaying in the form. The form reacts based on the data and its validation procedure, hense the name reactive forms. 
Model required for the form is created using attributes like Formgroup, Formcontrol and Formarrays. We need to import ReactiveFormsModule before we work with these coomponents in ur App. The validation based attributes are set at the Component level instead of the HTML Template level. 

Reactive forms define the structure of the HTML page in a Component class and also defines the elements of the form inside UR component itself.

### Dirty vs Touched in NgForms:
- dirty: A Control is said to be dirty if the user has changed the value in the user interface. 
- touched: A control is said to be touched if it triggers a Blur Event on the control. 

## Lazy Loading and creating Modules
- Only Modules can be Lazy loaded. Components, services of the Lazy loaded Module are limited to that Module only. 
- LoadChildren is the API that allows lazy loading thru routing feature. Refer the Code in Emp-Data App.

Create a module:
- ng g m Modules/ModuleName --routing

