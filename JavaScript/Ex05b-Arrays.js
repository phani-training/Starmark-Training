const data = [];
data.push("Record");//Adds the element to the bottom
data.unshift("First Record");//Adds the element to the start...

//Using iterator concept. U dont have to know the size of the array. It will never go out of bounds. It is forward only and read only.
console.log("Array loop using for...of")
for(const item of data){
    console.log(item)
}
console.log("Array loop using for loop")
for(let i =0; i < data.length; i++)
    console.log(data[i]);

//We use this for objects.
console.log("Array loop using for...in")
for (const key in data) {
    console.log(data[key])
}//Key is the index of the array.     
//Array iteration can be done using for...of, for...in and for loop

let empRec = {
    "Id" : 123, "Name" : "Phaniraj", "Address" : "Bangalore"
}
empRec.Name ="Shravani";

for(const propertyName in empRec){
    console.log("Property Name: " + propertyName + "....Property Value: " + empRec[propertyName] )
}

