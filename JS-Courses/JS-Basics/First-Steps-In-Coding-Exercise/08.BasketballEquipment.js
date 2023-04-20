function solve(input){
    let rentForTrainingForYear = Number(input[0]);

    let basketballSneakers = rentForTrainingForYear - rentForTrainingForYear * 40 / 100;
    let basketballEquip = basketballSneakers - basketballSneakers * 20 / 100;
    let basketballBall = basketballEquip / 4;
    let basketballAccessories = basketballBall / 5;

    let totalPrice = rentForTrainingForYear + basketballSneakers + basketballEquip + basketballBall + basketballAccessories;

    console.log(totalPrice);
}

solve(["365"]);
solve(["550"]);