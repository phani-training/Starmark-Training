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

