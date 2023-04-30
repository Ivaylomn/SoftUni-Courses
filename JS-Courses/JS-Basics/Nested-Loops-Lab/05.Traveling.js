function traveling(input) {
    let destination = input[0];
    let minPrice = Number(input[1]);
    let index = 1;
    let sum = 0;
    while (destination !== "End") {
        index++;
        while (sum < minPrice) {
            sum += Number(input[index]);
            index++;
        }
        console.log(`Going to ${destination}!`);
        destination = input[index++];
        minPrice = Number(input[index]);
        sum = 0;
    }
}

traveling(["Greece",
    "1000",
    "200",
    "200",
    "300",
    "100",
    "150",
    "240",
    "Spain",
    "1200",
    "300",
    "500",
    "193",
    "423",
    "End"
]);
