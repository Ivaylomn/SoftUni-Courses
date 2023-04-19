function solve(input){
    const pricePerMeters = 7.61;
    const discount = 0.18;
    let meters = Number(input[0]);
    let totalPrice = meters * pricePerMeters;
    let discountFromTotalPrice = totalPrice * discount ;
    console.log(`The final price is: ${totalPrice - discountFromTotalPrice} lv.`);
    console.log(`The discount is: ${discountFromTotalPrice} lv.`);
}

solve(["50.50"]);
solve(["150"]);