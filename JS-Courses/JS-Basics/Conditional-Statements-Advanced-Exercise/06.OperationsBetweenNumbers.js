function operationsBetweenNumbers(input) {
    let numberOne = Number(input[0]);
    let numberTwo = Number(input[1]);
    let operation = input[2];

    let result = "";
    if (operation === "+") {
        let operations = numberOne + numberTwo;
        if (operations % 2 === 0) {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - even`;
        } else {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - odd`;
        }
    } else if (operation === "-") {
        let operations = numberOne - numberTwo;
        if (operations % 2 === 0) {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - even`;
        } else {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - odd`;
        }
    } else if (operation === "*") {
        let operations = numberOne * numberTwo;
        if (operations % 2 === 0) {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - even`;
        } else {
            result = `${numberOne} ${operation} ${numberTwo} = ${operations} - odd`;
        }
    } else if (operation === "/") {
        if (numberOne !== 0 && numberTwo !== 0){
            let operations = numberOne / numberTwo;
            result = `${numberOne} ${operation} ${numberTwo} = ${operations.toFixed(2)}`;
        } else {
            result = `Cannot divide ${numberOne} by zero`;
        }
    } else if (operation === "%") {
        if (numberOne !== 0 && numberTwo !== 0){
            let operations = numberOne % numberTwo;
            result = `${numberOne} ${operation} ${numberTwo} = ${operations}`;
        } else {
            result = `Cannot divide ${numberOne} by zero`;
        }
    }

    console.log(result);
}

operationsBetweenNumbers(["10","12","+"]);
operationsBetweenNumbers(["10","1","-"]);
operationsBetweenNumbers(["7","3","*"]);
operationsBetweenNumbers(["123","12","/"]);
operationsBetweenNumbers(["10","3","%"]);
operationsBetweenNumbers(["112","0","/"]);
operationsBetweenNumbers(["10","0","%"]);
