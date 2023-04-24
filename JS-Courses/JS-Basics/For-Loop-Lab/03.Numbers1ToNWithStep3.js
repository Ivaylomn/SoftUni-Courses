function solve(input) {
    let num = Number(input[0]);

    for (let i = 1; i <= num; i += 3) {
        console.log(i);
    }
}

solve(["10"]);
solve(["7"]);
solve(["15"]);