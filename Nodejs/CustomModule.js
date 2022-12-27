module.exports.simpleFunc = function(){
    console.log("Simple Function is called");
}

module.exports.mathTable = function(num = 5){
    console.log(`The Multiplication Table for ${num}`);
    for(let i =1; i <= 10; i++){
        console.log(`${num} X ${i} = ${num * i}`);
    }
    console.log("-----------------------------------------");
}

module.exports.employee = class{
    constructor(id, name, address){
        this.id = id;
        this.name = name;
        this.address = address
    }

    display(){
        console.log(`${this.name} from ${this.address}`);
    }
}