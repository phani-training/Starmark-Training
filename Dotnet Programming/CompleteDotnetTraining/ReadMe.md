# .NET Framework
![image](https://user-images.githubusercontent.com/79626160/210948417-4f72eb36-17f0-485b-abd0-b20564385f25.png)

# .NET Execution Model
![image](https://user-images.githubusercontent.com/79626160/210948542-bb1747ad-959a-4b73-b4f3-4b52ab108cdf.png)

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

# For vs. Foreach
1. C# supports 2 iterations for Arrays and Collections: For and ForEach
2. For Loop allows to access the elements of the collection using indexer. 
	- For loop can be looped in bi-directional manner. 
	- U should know the size of the collection and should be within the size while U iterate, there are chances that U might loop out of the collection. 
	- It can be used to assign data to the elements of the collection. 
3. Foreach is a way of traversing the array like an Enumerator.
	- Allows to access each element within the collection.
	- Will always ensure that the iteration does not go out of bounds and UR traversing is safe. 
	- It is forward only and readonly.
	- Foreach can be applied only on collections. The in section of the foreach will work only if the variable is a collection object. 

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

# Typical Class Design:
![image](https://user-images.githubusercontent.com/79626160/210948630-798a406f-063a-41e9-b3dc-32b40c6d21d0.png)

# System.Object
 - C# is a language that is used in .NET which supports multiple languages.
 - There is a common base type for all languages called as System.Object.
 - C# has a keyword called object to it. 
 - All the types of .NET are derived from object. Everything is object. 
 - The derivation is implicit.
 - All variables of any kind can be stored as object. This is implicit. When a variable converts to an object, it is called as BOXING. It will box(Wrap) the data as an object.
 - U need to UNBOX the object when U want to call any specific functions on it. This operation is explicit. This is done either by using C Style casting, or using the Convert Class or using the is and as operators.
 - object gives 4 functions that can be modified by the sub classes. 
 - GetType ->Gets the internal data type of the object that is stored.
 - ToString -> Gets the string representation of the object. 
 - GetHashCode -> Gets the unique ID of the object created in the CLR.
 - Equals(other) -> Gives a bool value that contains the logical equivalence of the object with the other
 - Rules of UNBOXING:
	- Any typecasting that happens during unboxing should be done to the same type from which the object is boxed. 
	- If the objects holds the value of a integer, it must be typecasted to integer only, not to even the implicitly convertable types. 
	- The keywords is and as can be used to check and then convert for reference types: arrays, classes, strings, delegates...

# Constructors
- Constructors are sp functions that are invoked implicitly when an object of the class is created. 
- new keyword is the formal way used to invoke the constructor.
- It has the same name of the class and will not have any return type.
- U can have private constructors also. 
- It can have parameters to it as it is like a function only. 
- The constructor with no parameters is called Default constructor and the one with parameters are called Parameterized Constructors.
- If U dont provide a constructor, .NET itself will have one constructor which initializes the values internally for the fields.

# Method Overriding
- A Base class method can be modified in the derived class without altering the signature of the base method. 
- In C#, only methods that are marked as virtual in the base class can be overriden in the derived class. 
- The derived class will override the methods using override keyword, there by notifying the system that the method has been modified. 
- static methods cannot have virtual or override keywords.
- Method overriding promotes a concept called RUNTIME POLYMORPHISM.
- U can change the business rules as per the new requirements.
- base keyword is used to refer the immediate base class.
- When a base class's non virtual function is reimplemented in the derived class, the object of the base class will hide the implementation of the derived class.
- However, u will get a warning from the compiler when u try to reimplement the base method, warning can be removed using the new keyword that should be placed before the return type of the method. But the behavior of the method will not change, and <u>it is not method overriding</u>. 

# Abstract Classes
- Abstract class is one that contains one or more abstract methods in it. 
- An Abstract method is a function that does not have an implementation. 
- The method must be implemented by the derived class.
- The class is incomplete, U cannot instantiate the class. 
- An abstract class can have normal methods as well as virtual methods in it. 
- If a class is derived from an abstract class, it must implement all the abstract methods of the base class, else even this class should be marked as abstract.

# Interfaces:
- Interfaces are like abstract classes that has only abstract methods. 
- Interface names should be prefixed with I.
- U cannot have fields or implementation methods in Interfaces(Atleast upto C#8.0)
- Interfaces member are public, so no access specifier should be mentioned while declaring the methods. 
- The class that implements the interface is obligated to implement all the methods of the interface. If not should be marked as abstract and the non implemented methods must be re declared using abstract keyword. 
- An interface defines a contract which the class will comply with. The interface defines what are the operations that the class can perform. The Class would provide the real implementation of the desired Functionality
- A Class can implement multiple interfaces at the same level. 
- An interface can be implemented either implicitly or explicitly. 
- Explicit Implementation would be done using the InterfaceName.Method name, in this case, U should not have access specifier defined. Refer the code. 

# Sealed Classes and Sealed Methods
- Sealed classes are created to ensure that the class can only be used as an object, but cannot be inherited. 
- Sealed methods ensure that the method will not be overriden by the derived classes. Sealed methods can reside in normal classes. 
- Sealed methods must be followed by override. It implies that only virtual methods of the base class can be made as sealed in their derived classes. 
- String is a sealed class. U cannot inherit another class from it.

# Exception Handling
- Exceptions in .NET are objects of a class called System.Exception. 
- There are exceptions for all kinds of system related runtime issues. 
- Exceptions in C# are handled using try....catch....finally block. 
- try block contains the code that could raise an Exception.
- catch block can handle those exceptions that are thrown by the system or the Application as objects of class derived from System.Exception
- finally block is more like code cleaning that is executed on all the conditions. 
- Exceptions are raised in .NET using throw keyword.

# Static Constructors and Static Classes
- static classes are those that have a modifier static at the class declaration.
- These classes cannot have instance methods, they are refered directly by their classname.
- Static classes have only static members, so there will be no intention to create an instance of the same. So static keyword at the class level restricts the user from creating an instance of the class.
- Static classes can have constructors using static keyword. Normal classes also have static constructors to inject dependencies to the static members of the class. 
- Static constructors cannot be parameterized. U cannot access specifier to it. 
- It is implicitly invoked by the .NET when the first reference of any static member of the class is made.
- It is called once and only once for the execution of the program.
