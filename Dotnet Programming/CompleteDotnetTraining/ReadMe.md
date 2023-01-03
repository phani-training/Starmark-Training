# C# Basics
- C# is the programming language used for developing .NET Apps. 
- VS is the IDE for developing .NET Apps at an industrial Scale. 
- VS develops the Apps using Solution. A Solution is a comprehensive group of Projects.
- Each Project is a group of Files of the type .cs, .config. xml, images and some more.
- UR Application is grouped as .Sln and with multiple projects in it. 

# C# Entry point:
1. Main Function is the entry point of the Application. 
2. It is a part of the class, so it should be static. C# does not allow to create global variables
3. Main is case sensitive. 
4. It can return int or void. It can have either a string Array as Parameters or Nothing. 
5. You can display the content using a Static class called Console. Console class has functions to display the content on the Default Console of the System. For Console Apps, this is the ouput window. Its WriteLine method is used to write  text content on the Output Window.
6. To take inputs from Console, we can use the ReadLine method which returns string. 

# Data Types in C-Sharp
1. C# has its data types based on the common type system provided by .NET Framework.
2. The .NET Framework is a language independent Technology where multiple languages work together. It defines a set of data types that are available for all the .NET Languages.  
3 There are 2 types generally: Value Types(Primitive types) and Reference Types(UDTs)
4. For the types of the CTS, C# has equivalent keywords to represent it. 
5. Value Types are those types that are commonly used in all the programming languages:
	- Integral Types: Byte(byte), Int16(short), Int32(int), Int64(long)
	- Floating Types: Single(float), Double(double), Decimal(decimal)
	- Other Types: Boolean(bool), Char(char), DateTime
	- User Defined Value Types(UDTs): enums and structs.
6. Strings, Arrays, Classes come as Reference types where they are objects of a class. 
7. Convert class is used to convert the data of one type to another. 
8. For converting strings to the value types, we can use Parse methods from their respective Wrapper classes. 
9. All numeric types come with an Unsigned version of the data types. 
10. Every data type has a Range of the values that can be stored in it. 
11. Conversion that happens within the System itself is called as Implicit Casting.
12. Conversion of the data that we do for our app requirement is called explicit casting. U can use Convert Class to perform conversions from one type to another in C#. 
13. Check for overflows can be done by setting a check option in the Project->Debug Settings to check for arithematic overflows so that unsafe casting is avoided. By doing this, any unsafe casting will be thrown as Exceptions. 
14. U can also use checked block for any unsafe arithematic castings within a block of Code. example is shared. 

# Enums. 
1. Enums are User defined data types that can allow us to store the data as Named Constants. They are integral types. Storing the data and refering them as names instead of numbers is the concept of Enums. 
2. Info related to the enums can be obtained using a .NET class called Enum 
3. GetValues gets the values of the enum type
4. Parse method is used to get the parsed value of the Enum type taken from string.
5. Enum.Parse returns object that has to be typecasted to the specific Enum Type.

# Structs:
1. They are User defined Value Types which are also called as Light Classes.
2. Based on the C++ structs, it allows to create fields and methods.
3. It is not object oriented. 
4. Structs cannot have default constructor, it will be provided by the .NET itself. However, U can create parameterized constructor. The properties of the Struct must be set explicilty when U create a construtor.
5. Structs are mainly created for data carrier classes. 

# Arrays:
- Fixed size data structure is the main feature of array. 
- All arrays are instances of a class called System.Array. With Array class, we have APIs to get info about the array.
- Important properties: Length, Rank. 
- Important Methods: GetLength, Clone, Copy, CopyTo...
- Arrays are fixed in size, U cannot add, remove the elements after they are created. U can modify the data within the array.

# Functions:
- Functions in C# are always a part of a class, struct or an interface.
- Functions are of 2 kinds in C# =>static and instance functions. 
- static functions give the scope of global functions. It works more like a singleton function. 
	- static functions cannot be called by the instances of the class. 
	- U cannot call instance methods in a static function even if it is in the same class. For that U should create an instance of the class and thru the instance U can call those methods.
	- However, conversly U can call. 
	- static methods are not involved in method overriding or any other OOP features.
- instance based methods are used to manupulate the instance fields of the class. Usually the fields of the class will be hidden to the outside world. To access them, we use methods or properties.
	- instance methods can be accessed outside the class only by creating an instance(object) of the class.
	- U can call static methods in the instance methods. 
	- They can be part of the OOP process like overriding, inheritance, abstractions and polymorphism.
- Functions need parameters as dependency injectors for the method implementation. 
- Any value that U want to send to the caller is done using return values 
- A method in C# can have only one return value. 
- However, U can use ref and out parameters to get the values by reference. 
- To pass variable no of args to a function, we can use params keyword for a parameter
	- U can have only one params parameter in a given function
	- It should be the last of the parameter list. 
	- U cannot pass params by ref or by out. 
	- params are used in Console.WriteLine, 

# Classes and Objects
 - Class is a UDT Reference type that is created to represent real world Entities. 
 - With the class, U get a host of features of OOP that could be applied on ur classes. 
 - Classes can be nested if U want to restrict the class usage only within the Parent class. 
 - Classes is a composition of fields(Data), properties(Accessors), methods(Functions) and events(Actions on the object). 
 - Fields are the charectistics of the object, Functions are actions performed by the object, events are actions performed on the object. Properties are setters and getters for the private fields so that they can be used like regular variables. 
 - When U design a class or its subclasses, U follow the principles of OOP called as SOLID Principles. 
 - S : Single Responsibility Principle ->One class should do only one kind of operation.
 - O : Open Closed Principle
 - L : Luskov's substitution Principle
 - I : Interface Segregation Principle.
 - D : Dependency Principle. 

