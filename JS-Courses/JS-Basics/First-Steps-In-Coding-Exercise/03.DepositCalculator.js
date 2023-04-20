function solve(input){
    let depositPrice = Number(input[0]);
    let depositPerMonth = Number(input[1]);
    let yearsRest = Number(input[2]) / 100;

    let amount = depositPrice + depositPerMonth * (depositPrice * yearsRest) / 12;

    console.log(amount);
}

solve(["200", "3", "5.7"]);
solve(["2350", "6", "7"]);
