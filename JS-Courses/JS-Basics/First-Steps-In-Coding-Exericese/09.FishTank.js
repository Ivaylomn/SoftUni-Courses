function solve(input) {
    let lenght = Number(input[0]);
    let width = Number(input[1]);
    let height = Number(input[2]);
    let percentage = Number(input[3]) / 100;

    let volume = lenght * width * height;
    let volumeInLiters = volume / 1000;
    let needLiters = volumeInLiters * (1 - percentage);

    console.log(needLiters);
}

solve(["85", "75", "47", "17"]);
solve(["105", "77", "89", "18.5"]);