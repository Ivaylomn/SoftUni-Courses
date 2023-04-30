function cake(input) {
    let width = Number(input[0]);
    let length = Number(input[1]);
    let index = 2;
    let cakeAmount = width * length;
    let command = input[index];
    while (command !== "STOP") {
        let piceOfCake = Number(input[index]);
        if (cakeAmount - piceOfCake < 0) {
            console.log(`No more cake left! You need ${piceOfCake - cakeAmount} pieces more.`);
            return;
        }
        cakeAmount -= piceOfCake;
        index++;
        command = input[index];
    }

    console.log(`${cakeAmount} pieces are left.`);
}

cake(["10",
    "10",
    "20",
    "20",
    "20",
    "20",
    "21"
]);
cake(["10",
    "2",
    "2",
    "4",
    "6",
    "STOP"
]);