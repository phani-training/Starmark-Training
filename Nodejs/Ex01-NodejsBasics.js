console.log("Testing the Nodejs code");

const addFunc = (v1, v2) => v2 + v1;

console.log("The Added value: " + addFunc(123, 23));

const data = [
    {"id": 123, "name" : "Phaniraj", "address" :"Bangalore"},
    {"id": 124, "name" : "Gopal", "address" :"Madras"},
    {"id": 125, "name" : "Hrishikesh", "address" :"Bombay"},
    {"id": 126, "name" : "Govind", "address" :"Udupi"},
    {"id": 127, "name" : "Krishna", "address" :"Mangalore"}
]

console.table(data);