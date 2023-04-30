function solve(input) {
    let n = Number(input[0]);

    let counter = 1;
    while (n >= counter) {
        console.log(`${counter}`);
        counter = counter * 2 + 1;
    }
}

solve(["3"]);
solve(["8"]);
solve(["17"]);
solve(["31"]);