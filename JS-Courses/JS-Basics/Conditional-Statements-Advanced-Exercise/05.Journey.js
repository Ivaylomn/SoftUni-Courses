function journey(input) {
    let budget = Number(input[0]);
    let season = input[1];

    let price = 0.0;
    let country = "";
    let typePlace = "";
    switch (season) {
        case "summer":
            if (budget <= 100) {
                price = budget * 0.30;
                typePlace = "Camp";
                country = "Bulgaria";
            } else if (budget <= 1000) {
                price = budget * 0.40;
                typePlace = "Camp";
                country = "Balkans";
            } else if (budget > 1000) {
                price = budget * 0.90;
                typePlace = "Hotel";
                country = "Europe";
            }
            break;
        case "winter":
            if (budget <= 100) {
                price = budget * 0.70;
                typePlace = "Hotel";
                country = "Bulgaria";
            } else if (budget <= 1000) {
                price = budget * 0.80;
                typePlace = "Hotel";
                country = "Balkans";
            } else if (budget > 1000) {
                price = budget * 0.90;
                typePlace = "Hotel";
                country = "Europe";
            }
            break;
    }

    console.log(`Somewhere in ${country}`);
    console.log(`${typePlace} - ${price.toFixed(2)}`);
}

journey(["50", "summer"]);
journey(["75", "winter"]);
journey(["312", "summer"]);
journey(["678.53", "winter"]);
journey(["1500", "summer"]);