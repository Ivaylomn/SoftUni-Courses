function godzillaVsKong(input) {
    let budget = Number(input[0]);
    let extraCount = Number(input[1]);
    let pricePerEquipment = Number(input[2]);

    let decorPrice = budget * 0.10;
    let priceForCloth = extraCount * pricePerEquipment;

    if (extraCount > 150) {
        priceForCloth -= priceForCloth * 0.10;
    }

    let totalPriceForMovie = decorPrice + priceForCloth;

    if (budget >= totalPriceForMovie) {
        console.log("Action!");
        console.log(`Wingard starts filming with ${(budget - totalPriceForMovie).toFixed(2)} leva left.`);
    } else if (budget < totalPriceForMovie) {
        console.log("Not enough money!");
        console.log(`Wingard needs ${(totalPriceForMovie - budget).toFixed(2)} leva more.`);
    }
}

godzillaVsKong(["20000", "120", "55.5"]);
godzillaVsKong(["15437.62", "186", "57.99"]);
godzillaVsKong(["9587.88", "222", "55.68"]);
