class Item{
    constructor(id, name, price, quantity, image = ""){
        this.id = id;
        this.name = name;
        this.quantity = quantity;
        this.price = price;
        this.image =image;
    }

    getAmount = () => this.price * this.quantity;
}

const FoodItems = [
    {"id" : 123, "name" : "Ghee Masala Dosa", "price" : 75, "image" : "./Images/gmd.jfif"},
    {"id" : 124, "name" : "Set Dosa", "price" : 65, "image" : "./Images/sd.jfif"},
    {"id" : 125, "name" : "Pooris", "price" : 55, "image" : "./Images/pooris.jfif"},
    {"id" : 126, "name" : "1 Idly Vada", "price" : 55, "image" : "./Images/siv.jfif"},
    {"id" : 127, "name" : "2 Idlies", "price" : 30, "image" : "./Images/iv.jfif"},
]
class Cart{
    constructor(){
        this.items = [];
    }

    addToCart = (item) => this.items.push(item);

    removeFromCart = (id) =>{
        let index = this.items.findIndex(i=>i.id == id);
        if(index < 0)
         throw "Item not found";
        this.items.splice(index, 1); 
    }

    getTotalBill = () => {
        let total = 0;
        for(const item of this.items){
            total += item.getAmount();
        }
        return total;
    }
}
