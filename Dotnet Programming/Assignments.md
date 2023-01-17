# Assignments for C# Programming

### Assignment 1
Write a program that displays the range of all the floating and integral types of.NET CTS

### Assignment 2
Write a function that takes an array of numbers and it should display the Odd and Even numbers

### Assignment 3
Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the result based on the operator the user has typed. It should be in a loop until the user specifies to close it.

### Assignment 4:
Write a program that creates an array and displays the contents of the array. The array should be created dynamically. It means that the size, type should be set by the user of the Program. Take inputs for the values also. Finally it should display the values of the array.


### Assignment 5:
Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library. It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application. 

### Assignment 6
Implement the body for the following function:

```
static boolean isValidDate(int year, int month, int day) { 
	// do stuff here
	return false;
}
```
The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false.

For example,

year=2018, month=13, day=1 is an invalid date as the possible values for month is 1 to 12.

year=2018, month=2, day=29 is an invalid date as the maximum days in February is 28 in the year 2018

year=2016, month=2, day=29 is a valid date.

Write a C# program to call the above function multiple times with different values.

### Assignment 7
Implement the body for the following function:
```
static boolean isPrimeNumber(int num) {
	// do stuff here
	return false;
}
```
The function should check and return true only if the number passed as argument is a prime number.

Write a C# program to call the above function multiple times with different values.

### Assignment 8
Implement the C# function listed below:
```
public static void printCalendar(int month, int year) {
	/// do stuff here
}
```
The function should accept month and year and print the calendar for the same. If inputs are invalid, appropriate error message/s should be printed.

Sample output for the inputs (8, 2018):
![image](https://user-images.githubusercontent.com/79626160/186892071-5a8bf6da-4795-44a7-97e5-f2a382714c87.png)

PS:
Do not use any builtin C# classes like DateTime
Divide the function into small reusable functions, if possible.

### Assignment 9
Write a function called "reverseByWords", that takes a sentence (string) as an input, and returns another string. The return value must be a sentence in which the words in the original sentence appear in reverse order.
```
public static string reverseByWords(string sentence) {
	// do stuff here
	return null;
}
```
For example,

String out = reverseByWords("my name is vinod and i live in bangalore");


// the variable "out" should be equal to "bangalore in live i and vinod is name my".


Call the function in main, multiple times by supplying multiple values and verify the same.

### Assignment 10
Write a function called "inWords" that takes a number between 1 and 99,99,99,999 and returns a String representing the input number in words.
```
public static String inWords(int num) {
	// do stuff here
	return null;
}
```
For example,

inWords(12345);
// should return "twelve thousand three hundred forty five"

inWords(10203040);
// should return "one crore two lakh three thousand forty"

inWords(101);
// should return "one hundred one"

Call the function in main, multiple times by supplying multiple values and verify the same.

### Assignment 11
Write a Function that returns a interest amount for a Principal Amount for a term with a specific rate of interest  Let the inputs for the function be in the form of parameters. 


### Assignment 12
Create a Console App that stores the Customer Records into an Array.

The App should allow the User to Add, Remove, Update and Find the Customers by ID.

The App should be a menu-driven App that allows the user to choose an option and perform the expected operation. The App should not terminate at any point unless chosen by the User. <br/>
Make the App Interactive with User inputs coming from Console. <br/>
Hint:
Create separate classes for Customer, CustomerRepo which have functions of Operations, and UI Class that will handle the UI of the Application. 
Make the App as modular as possible.

### Assignment 13
Create a Console App that stores accounts of a Bank. The Account class should be an Abstract class that contains details of Id, Name, Balance, Credit, and Debit Operations. The CalculateInterest will be an abstract method. <br/>
Implement this method in the Subclasses like SB Account, RD Account, and FD Account. <br/>Using Runtime polymorphism, create objects of the Account class and examine how the CalculateInterest function is called.

### Assignment 14
Create an Class called Patient with Properties as ID, Name, Phone No, BillAmount<br/>
Create Function to write the Patient Details to a File.<br/>
Create a Function to read the details of the Patient from the File.<br/> 
Test the Functions with different Values and observe the Functionality.<br/>

PS: The data should be in the form of a CSV.

### Assignment 15
Create an interface called IDataComponent that has CRUD Functions in it to store the data of an Employee with details like ID, Name, Address and Salary. <br/>
The following functions are required: Add, Remove, Update, FindByID and FindByName.<br/>
The Functions should take primitive values as parameters. <br/>
Implement the interface in a File Component Class that will store the data of the employees into a single CSV file. <br/>
Create an UI Component that will create the interface object and call the appropriate method using a Menu driven App. The Menu should allow the user to choose the operation and appropriately perform the operations. <br/>

PS: <br/>
All the data should be stored in the Text file as CSV. <br/>
U can choose the appropriate collection class required.<br/>
Use StreamReader and StreamWriter to perform the File Operations.<br/>

### Assignment 16
Create a new Class called SerializationComponent with the following features:<br/>
It should store the data of a list of Employees in an XML File.<br/>
It should return the data of XML as a List of Employees.<br/>

U should create the instance of the Component and call those functions in the Main to test. <br/>
Test the code with different kinds of data and observe the results

### Arrays and Coding Assignments

- Write a program that takes an array as argument, it should display the transpose matrix format of the array
- Write a program in C# Sharp to find sum of rows and display the sum as a new column for a Matrix
- Write a C#  program to display the date of past and future fifteen years of a specified date.
/*
 * Base Date:        2/29/2016                                                 
 * 
 1 year(s) ago:        2/28/2015                                                 
 2 year(s) ago:        2/28/2014                                                 
 3 year(s) ago:        2/28/2013                                                 
 4 year(s) ago:        2/29/2012                                                 
 5 year(s) ago:        2/28/2011  
 */

- Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.
- Write a program in C# to read a sentence and replace lowercase characters by uppercase and vice-versa.

### Association Program
- Create a Class by name Bill
- Bill has properties: BillNo, BillDate, BillHolder, BillAmount
- Create a class called Item: Id, Perticulars, UnitPrice, Quantity
- Create a Program the provides Itemized billing for a given Customer. 

## Database App
- Create a Database Application to store work on Movie Database. 
- The database will have info about a Movie, its actors and its director.
- U should store all the info in the database. 
- It should perform all the CRUD operations.  
- UR APIs should be in a DLL. The UI part will be the Console App
