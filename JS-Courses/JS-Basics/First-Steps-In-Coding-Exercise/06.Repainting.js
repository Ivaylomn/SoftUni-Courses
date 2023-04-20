function solve(input){
    const nylonPrice = 1.50;
    const paintPricePerLiter = 14.50;
    const paintThinnerPrice = 5.00;
    const priceForBag = 0.40;

    let nylonAmount = Number(input[0]);
    let paintAmount = Number(input[1]);
    let thinnerAmount = Number(input[2]);
    let hours = Number(input[3]);

    let priceForAllNylon = (nylonAmount + 2) * nylonPrice;
    let priceForAllPaint = (paintAmount + paintAmount * 10 / 100) * paintPricePerLiter;
    let priceForAllThinner = thinnerAmount * paintThinnerPrice;

    let totalPriceForMaterials = priceForAllNylon + priceForAllPaint + priceForAllThinner + priceForBag;
    let priceForMaster = (totalPriceForMaterials * 30 / 100) * hours;

    let totalPrice = totalPriceForMaterials + priceForMaster;

    console.log(totalPrice);
}

solve(["10", "11", "4", "8"]);
solve(["5", "10", "10", "1"]);