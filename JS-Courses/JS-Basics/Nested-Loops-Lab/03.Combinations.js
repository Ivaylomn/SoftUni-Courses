function combinations(input) {
    let number = Number(input[0]);
    let count = 0;
    for (let i = 0; i <= number; i++) {
        for (let j = 0; j <= number; j++) {
            for (let d = 0; d <= number; d++) {
                if (i + j + d === number) {
                    count++;
                }
            }
        }
    }

    console.log(count);
}

combinations(["25"]);
combinations(["20"]);
combinations(["5"]);