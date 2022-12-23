//Function used to handle onchange event of the Input Boxes to check for a valid number.
function onCheck(){
    let num = parseFloat(document.getElementById("txtFirstValue").value);
    if(Number.isNaN(num)){
        alert("Invalid Input")
    }
}

//Function used to handle the Click event of the button that performs the calc operation. 
function onClick(){
    const firstValue = parseFloat(document.getElementById("txtFirstValue").value);
    if(Number.isNaN(firstValue)){
        alert("Its not a valid Number");
        return;
    }
    const secondValue = parseFloat(document.getElementById("txtSecondValue").value);
    const operand = document.getElementById("operator").value;
    let result =0.0; //To store the computed values. 
    switch(operand){
        case "+" : 
            result = firstValue + secondValue ; 
            break;
        case "-":
            result = firstValue - secondValue;
            break;
        case "X":
            result = firstValue * secondValue;
            break;
        case "/":
            result = firstValue / secondValue;
            break;
    }
    document.getElementById("spResult").innerText = result;
}