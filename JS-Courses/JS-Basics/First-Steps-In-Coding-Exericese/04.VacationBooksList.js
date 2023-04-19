function solve(input){
    let numberOfPages = Number(input[0]);
    let pagesPerHour = Number(input[1]);
    let daysCount = Number(input[2]);

    let result = numberOfPages / pagesPerHour / daysCount;

    console.log(result);
}

solve(["212", "20", "2"])
solve(["432", "15", "4"])