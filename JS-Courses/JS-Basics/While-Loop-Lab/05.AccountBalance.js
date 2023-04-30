function accountBalance(input) {
    let index = 0;
    let totalMoney = 0;
    while (input[index] !== "NoMoreMoney") {
        let currentElement = Number(input[index]);
        if (currentElement < 0) {
            console.log("Invalid operation!")
            break;
        }
        console.log(`Increase: ${currentElement.toFixed(2)}`);
        totalMoney += currentElement
        index++;
    }

    console.log(`Total: ${totalMoney.toFixed(2)}`);
}

accountBalance(["5.51", "69.42", "100", "NoMoreMoney"]);
