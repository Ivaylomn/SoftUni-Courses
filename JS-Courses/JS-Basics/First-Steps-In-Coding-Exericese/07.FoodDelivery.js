function solve(input){
    const chickenMenuPrice = 10.35;
    const fishMenuPrice = 12.40;
    const veganMenuPrice = 8.15;
    const deliverePrice = 2.50;

    let amountChikenMenu = Number(input[0]);
    let amountFishMenu = Number(input[1]);
    let amountVeganMenu = Number(input[2]);

    let totalPriceForMenu = (amountChikenMenu * chickenMenuPrice) + (amountFishMenu * fishMenuPrice) +
    (amountVeganMenu * veganMenuPrice);
    let priceForDesert = totalPriceForMenu * 20 / 100;

    let totalPriceForOrder = totalPriceForMenu + priceForDesert + deliverePrice;

    console.log(totalPriceForOrder);
}

solve(["2", "4", "3"]);
solve(["9", "2", "6"]);


