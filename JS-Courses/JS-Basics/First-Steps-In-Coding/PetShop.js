function solve(input){
    let dogFoodPrice = 2.50;
    let catFoodPrice = 4;
    let result = dogFoodPrice * input[0] + catFoodPrice * input[1];
    console.log(`${result} lv.`)
}

solve(["5", "4"]);
solve(["13", "9"]);