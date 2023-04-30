function vacation(input) {
    let neededMoneyForVacation = Number(input[0]);
    let availableMoney = Number(input[1]);

    let count = 0;
    let countForSpendMoneydays = 0;
    for (let i = 2; i < input.length; i += 2) {
        let command = input[i];
        let money = Number(input[i + 1]);
        count++;
        if (command === "spend") {
            availableMoney -= money;
            countForSpendMoneydays++;
            if (availableMoney < 0) {
                availableMoney = 0;
            }
        } else if (command === "save") {
            availableMoney += money;
        }
        if (countForSpendMoneydays === 5) {
            console.log("You can't save the money.");
            console.log(`${count}`);
        }
        if (availableMoney >= neededMoneyForVacation) {
            console.log(`You saved the money for ${count} days.`);
        }
    }
}

vacation(["2000",
    "1000",
    "spend",
    "1200",
    "save",
    "2000"
]);
vacation(["110",
    "60",
    "spend",
    "10",
    "spend",
    "10",
    "spend",
    "10",
    "spend",
    "10",
    "spend",
    "10"
]);
