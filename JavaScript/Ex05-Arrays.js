const fruits = ["Apples", "Mangoes", "Oranges"];//Array of 3 elements. 
fruits.push("Pine Apples");
const data = [];//blank array

//Get the reference of the element called lstItems
const ol = document.getElementById("lstItems");

//For of loop to iterate thro the elements of the array. 
for(const item of fruits){
    const value = "<li>" + item + "</li>"
    ol.innerHTML += value; //operator to append the content
}

//Using For Loop statement
function forLoopExample(ol) {
    for (let index = 0; index < fruits.length; index++) {
        const element = "<li>" + fruits[index] + "</li>";
        ol.innerHTML += element;
    }        
}