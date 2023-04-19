function solve(input) {
    const pens = 5.80;
    const markers = 7.20;
    const preparationPerLiter = 1.20

    let amountPens = Number(input[0]);
    let amountMarkers = Number(input[1]);
    let amountLitersPreparat = Number(input[2]);
    let discount = Number(input[3]) / 100;

    let priceForAllMaterials = (amountPens * pens) + (amountMarkers * markers)
        + amountLitersPreparat * preparationPerLiter;

    let totalPrice = priceForAllMaterials - (priceForAllMaterials * discount);

    console.log(totalPrice);
}

solve(["2", "3", "4", "25"])
solve(["4", "2", "5", "13"])