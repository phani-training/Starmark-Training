//Represents each Face Target...
class FaceTarget{
    constructor(name, year, photo, gender, id){
        this.name = name;
        this.year = year;
        this.photo = photo;
        this.gender =gender;
        this.id = id;
    }
}

//Represents the Repo class that does the bulk insertion
class FaceTargetRepo{
    bulkInsert(data){
        for(let item of data){
            //call the API for each record of the data.
        }
    }
    //It might have other VERBs: GET, PUT, DELETE...
}


let collection = [];
function createData(){
    //Could be reading from the source file....
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
    collection.push(new FaceTarget("Phaniraj", 1977, "img.jpg", "male", 123 ));
}
//call this to populate the collection
createData();

//Create the instance of the Repo class
const repo = new FaceTargetRepo();
//Call this function to perform the bulk insertion to the database...
repo.bulkInsert(collection);

