class Expense{
    static no = 0;
    constructor( detail, amount, date){
        this.id = ++Expense.no;
        this.date = date;
        this.detail = detail;
        this.amount = amount;
    }
}

class ExpenseManager{
    #expenses = []; //#makes it a private field of the class. 

    addNewExpense = (expense) => this.#expenses.push(expense);
    
    findExpenses = (detail) => this.#expenses.filter((e)=>e.detail.includes(detail));

    findExpensesByDate = (date) => this.#expenses.filter((e)=>e.date.toDateString() == date.toDateString());

    getAllExpenses = () => this.#expenses;

    getExpenseById = (id) => this.#expenses.find((e)=>e.id == id);

    modifyExpense = (id, expense) =>{
        let foundIndex = this.#expenses.findIndex(ex => ex.id == id);
        if(foundIndex == -1) throw "Expense not found to update";
        this.#expenses.splice(foundIndex, 1, expense);
    }
}



// const obj = new ExpenseManager();
// obj.addNewExpense(new Expense("Food at cafe", 100, new Date(2022, 11, 13)))
// obj.addNewExpense(new Expense("Brunch at cafe", 120, new Date(2022, 10, 23)))
// obj.addNewExpense(new Expense("Coffee at cafe", 10, new Date(2022, 11, 11)))
// obj.addNewExpense(new Expense("Tea at hotel", 10, new Date(2022, 11, 12)))

// let data = obj.getAllExpenses();
// for(const ex of data) console.log(ex.id);

// console.log("Searching on Detail......");
// data = obj.findExpenses("hotel");
// for(const ex of data) console.log(ex.id);

// console.log("Searching on Date......");
// data = obj.findExpensesByDate(new Date(2022, 11, 12));
// for(const ex of data) console.log(ex.id);

// const ex = obj.getExpenseById(2);
// ex.detail ="Modified with new INfo";
// obj.modifyExpense(2, ex);
// data = obj.getAllExpenses();
// for(const ex of data) console.log(ex.detail);