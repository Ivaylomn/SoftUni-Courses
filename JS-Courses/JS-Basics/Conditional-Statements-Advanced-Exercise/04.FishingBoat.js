function fishingBoat(input) {
    let budget = Number(input[0]);
    let season = input[1];
    let fisherCount = Number(input[2]);

    let shipPrice = 0.0;
    switch (season) {
        case "Spring":
            shipPrice = 3000;
            break;
        case "Summer":
        case "Autumn":
            shipPrice = 4200;
            break;
        case "Winter":
            shipPrice = 2600;
            break;
    }

    if (fisherCount <= 6) {
        shipPrice -= shipPrice * 0.10;
    } else if (fisherCount > 6 && fisherCount <= 11) {
        shipPrice -= shipPrice * 0.15;
    } else if (fisherCount >= 12) {
        shipPrice -= shipPrice * 0.25;
    }

    if (fisherCount % 2 === 0 && season !== "Autumn") {
        shipPrice -= shipPrice * 0.05;
    }

    if (budget < shipPrice) {
        console.log(`Not enough money! You need ${(shipPrice - budget).toFixed(2)} leva.`)
    }else {
        console.log(`Yes! You have ${(budget - shipPrice).toFixed(2)} leva left.`)
    }
}

fishingBoat(["3000","Summer","11"]);
fishingBoat(["3600","Autumn","6"]);
fishingBoat(["2000","Winter","13"]);
