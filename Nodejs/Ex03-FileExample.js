const fs = require("fs");

const file = "./Ex02-ConsumingModules.js";
///////////////////////////Sync Reading/////////////////////////////////////////////
function fileReadingSync(){
    const contents = fs.readFileSync(file, "utf-8");//It is basic English with 8 Bit charecter set. 
    
    console.log(contents);
}
///////////////////////////Async Reading/////////////////////////////////////////////
function fileReadingAsync(){
    fs.readFile(file, 'utf-8', function(err, data){
        if(err)
            console.error(err);
        else
            console.log(data)
    })
}

const obj = {"id" :123, "name":"testName", "address" : "Mysore"};

function writeToFile(){
    fs.writeFileSync("SampleTextFile.txt", JSON.stringify(obj), "utf-8")
}


function writeToFileAsync(){
    fs.writeFile("SampleTextFile.txt", "Sample text to write", (err)=>{
        if(err) console.log(err);
    })
}

function appendingTofile(){
    fs.appendFileSync("SampleTextFile.txt", "\nContent will be appended to the next line\n", "utf-8");
}
//Implement the Async version of the File Appending....

appendingTofile();
//writeToFileAsync();
//fileReadingSync()
//fileReadingAsync();
//writeToFile();
console.log("This code will execute after the file reading");