# JavaScript Programming
-------------------------------------------------------------------------------
1. JavaScript is a Client side scripting language. 
2. Client side scripting languages are those that are processed in the Browser. Browsers reside in the Client machines, hense the name client side Scripting language. 
3. Scripting languages are light weight and are embedded in the browsers as interpretors. JS Interpretor is mandatory for all browsers published in the market and is recommended by W3C. This makes JS the most popular scripting language. 
4. JS is managed by an Organization called ECMA(European Computers Manufacturers Association). They release the Documentations for JS and recommendations for the browser companies to incorporate the new features in a time bound manner.
5. It is called ECMAScript or simply ES. Current version is ES 11. 
6. Latest browsers implement the ES  versions and are frequently updated. 

## How to create and Execute JS Code?
1.  (JavaScript) JS code is written either in the HTML files or as text files with extension .js. 
2. They are included in the HTML documents as external files and are executed on the browser. 
3. With Nodejs, a Platform based on Javascript, U can run the JS files from the Terminals. 

## Variables and Consts in JS:
1. JS is a dynamic programming language where the data type is never defined. 
2. We use var, let or const to declare a variable in JS. 
3. const is used when U want immutable data.
4. let is the latest version of declaring variables. It is more scoped compared to var.
5. Even though variables are declared without data type info, internally they are holding a specific type:
    - number -> floating as well as integers.
    - string
    - boolean
    - object -> Class instances as well as arrays. 
    - undefined -> declare a variable and dont assign anything to it. 
6. U can check the internal type using typeof operator. 
Example is shared as Ex01-Variables.js.

## UI based Functions
1. JS provides 3 UI based interactive functions
    - alert function. => Display messages on popup windows of the browser. 
    - prompt function. => Take inputs based on a Question in an interactive manner.
    - confirm function. => Take Yes or No inputs from the user for a Question. 

## Functions:
1. Functions are blocks of statements that can be refered by a name and used frequently across the Application. 
2. Created for better maintainability. 
3. There are 3 ways of creating functions in JS
    - Named methods
    - Anonymous methods
    - Lambda Methods. 
4. Functions provide Modularity of the code. Modularity means one function should do only one job. 
5. All dependencies for the function should come as inputs or parameters to the function. 
6. Anything that U want to give back to the caller will be given as return values of the function. 

## Arrays:
1. Arrays are objects that can store multiple data of the same type and representable with a single name. 
2. It is created in JS using [] operator. 
3. Array comes from a class called Array of JS which has APIs to insert, delete, replace and many more activities.
4. Unlike other programming languages, Arrays in JS work like Collection classes.  
5. Some of the common methods used:
    - push : Used to add a new item to the bottom of the Array. 
    - splice: Used to add, remove and replace an item in the Array.
    - length: gets the no of elements in the array dynamically. 
    - filter: Gets a subset of the elements based on criteria. 
    - find: Gets the first matching record based on the criteria.
    - indexOf : Gets the Index of the element passed as arg. 
    - FindIndex: Gets the index of the Element based on a criteria.

## Classes:
1. Composite datatypes grouped into one unit is called as object
2. Objects in JS can be created 2 ways: Singleton objects or Function based objects.
3. Singleton objects are created using {} operator. They are set with properties. Example is shared.
4. From ES6, we have a keyword called class and constructor to create classes and objects.
5. Objects of the class are created using new keyword. This is called as Instantiation. 
6. With new operator, U can create multiple objects of the class. 
7. The class represents the schema of the object. It defines what the object will hold and can perform as operations. 
8. A Class can contain fields, methods, properties. 
9. Example shared ias Ex07-ObjectBasics.js

## Inheritance:
- Inheritance is a feature of OOP where U can extend the functionalities of one class into an other. It is based on the Principle of OOP called as Open-Closed Principle. A Class is closed for modification but open for extension. 
- New syntax of ES6 where we can create class like an Expression.
- Methods of the base class can be reimplemented in the derived class with the following rules: U cannot modify the parameters of the method. It should have the same method signature in the derived class.
- To refer the base class, u can use keyword called super(). super is the way to refer the immediate base class. Earlier versions of JS used base or prototype to refer the immediate base class. 
- Dont use Lambda Methods for overriding the methods as they are scoped only to the class it is created. So no overriding occurs. However, U could use the class methods to achieve the method overriding feature. 

## Maps Collection
 1. Maps are the way to store data in the form of key and value. Key is unique to the collection. 
 2. Map has functions like:
    - get => to get the value associated with the key
    - set => to add the key and value pair to collection. If the key already exists, it does not add to the collection
    - has => used to check if the key exists in the Map.

## ES 6 Features
#### var and let
- let keyword and const are the new ways of creating data in JS.
- const is used for refering data that does not modify over the course of time. 
- let allows to create variables that are scope based. 
- Earlier, we used another way called as var. 
- var is function based whereas let is scope based. There are only 2 scopes in var: one is global and another is function based.
- var adds to the global scope but let does not.  
- var gets hoisted itself to the upper scope which let does not. 
- var allows redeclaration within the same scope which is not allowed in let. 

#### Default Parameters:
- Parameters is what U define in the function. Arguements is what U pass to the function while calling it. 
```
function sampleFunc(message = "Good Morning") {
    console.log(message);
}
```

#### Rest Operator
- Used to set variable no of arguements.
- Rest parameter is created using ... operator. 
- U can have normal parameters in UR function. The Rest parameter should be the last of the parameter list. 
- The Rest parameter is always an array. 

#### Spread operator
-Rest operator is used to extract the remaining args of a function whereas the spread operator is to extract all the values of a collection.
-The spread operator unpacks elements of iterable objects like Arrays, Maps and Set. It is the opposite of rest parameter. 
-Spread operator is used to clone, append, merge collection objects 
    