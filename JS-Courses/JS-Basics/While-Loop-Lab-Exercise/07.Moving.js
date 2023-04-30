function moving(input) {
    let width = Number(input[0]);
    let length = Number(input[1]);
    let height = Number(input[2]);
    let flatSize = width * length * height;
    let index = 3;
    let sumBox = 0;
    let command = input[index];
    while (command != "Done") {
        sumBox += Number(input[index]);
        if (flatSize - sumBox < 0) {
            console.log(`No more free space! You need ${Math.abs(flatSize - sumBox)} Cubic meters more.`);
            return;
        }
        index++;
        command = input[index];
    }

    console.log(`${flatSize - sumBox} Cubic meters left.`)
}

moving(["10",
    "10",
    "2",
    "20",
    "20",
    "20",
    "20",
    "122"
]);
moving(["10",
    "1",
    "2",
    "4",
    "6",
    "Done"
]);