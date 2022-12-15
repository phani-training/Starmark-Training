//Create a global variable of array to store our data.
const myBooks = [];

//create operation.
function addItem(item) {
    myBooks.push(item)
}

//Read operation
const getAll = () => myBooks; //Lambda way of creating method....

//read by item....
function getItem(item){
    itemToSearch = item;//Only for the example of testing code. 
    // const recFound = myBooks.find(function(actual){
    //     console.log("Searching Item: " + acutal);
    // if(actual == item)
    //     return true;
    // else
    //     return false;
    // });

    const recFound = myBooks.find(b => b == item);
    return recFound;
}

const updateItem = (index, item)=>{
    // for (let i = 0; i < myBooks.length; i++) {
    //     if(i == index){
    //         myBooks[i] = item;
    //         return;
    //     }
    // }
    myBooks[index] = item;
}

const deleteItem = (index)=> myBooks.splice(index, 1);


/////////////////////////////////////Testing Purpose///////////////////////////////
//Use this to test the code....
// let itemToSearch;
// function findingcreteria(item){
//     console.log("Searching Item: " + item);
//     if(item == itemToSearch)
//         return true;
//     else
//         return false;
// }



// addItem("MyBook");
// addItem("HisBook");
// addItem("HerBook");
// addItem("OurBook");

// const foundBook = getItem("MyBook");
// console.log("The found book is " + foundBook);


