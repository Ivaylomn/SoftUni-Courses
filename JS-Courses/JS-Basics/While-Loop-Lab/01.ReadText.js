function readText(input) {
    let index = 0;
    let currentInput = input[index];

    while (currentInput !== "Stop") {
        console.log(currentInput);
        index++;
        currentInput = input[index];
    }
}

readText(["Nakov",
    "SoftUni",
    "Sofia",
    "Bulgaria",
    "SomeText",
    "Stop",
    "AfterStop",
    "Europe",
    "HelloWorld"
]);
readText(["Sofia",
    "Berlin",
    "Moscow",
    "Athens",
    "Madrid",
    "London",
    "Paris",
    "Stop",
    "AfterStop"
]);

