function toyShop(input) {
    let excursionPrice = Number(input[0]), puzzleCount = Number(input[1]), dollsCount = Number(input[2]),
        bearsCount = Number(input[3]), minnionCount = Number(input[4]), trucksCount = Number(input[5]);

    let toysAmount = puzzleCount + dollsCount + bearsCount + minnionCount + trucksCount;
    let totalPriceForToys = puzzleCount * 2.60 + dollsCount * 3.0 + bearsCount * 4.10 +
        minnionCount * 8.20 + trucksCount * 2.0;

    if (toysAmount >= 50) {
        totalPriceForToys -= totalPriceForToys * 0.25;
    }

    totalPriceForToys -= totalPriceForToys * 0.10;

    if (totalPriceForToys < excursionPrice) {
        console.log(`Not enough money! ${(excursionPrice - totalPriceForToys).toFixed(2)} lv needed.`);
    } else {
        console.log(`Yes! ${(totalPriceForToys - excursionPrice).toFixed(2)} lv left.`)
    }
}

toyShop(["40.8", "20", "25", "30", "50", "10"]);
toyShop(["320", "8", "2", "5", "5", "1"]);

