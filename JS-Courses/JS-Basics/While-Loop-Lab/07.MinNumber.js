function minNumber(input) {
    let index = 0;
    let minNumber = Number.MAX_SAFE_INTEGER;

    while (input[index] != "Stop") {
        if (Number(input[index]) <= minNumber) {
            minNumber = input[index];
        }
        index++;
    }

    console.log(minNumber);
}

minNumber(["100",
"99",
"80",
"70",
"Stop"]);