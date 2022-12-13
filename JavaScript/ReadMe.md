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

    