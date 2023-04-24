function summerOutfit(input) {
    let degrees = Number(input[0]);
    let time = input[1];

    let outfit = "";
    let shoes = "";
    if (degrees >= 10 && degrees <= 18) {
        switch (time) {
            case "Morning":
                outfit = "Sweatshirt";
                shoes = "Sneakers";
                break;
            case "Afternoon":
            case "Evening":
                outfit = "Shirt";
                shoes = "Moccasins";
                break;
        }
    } else if (degrees > 18 && degrees <= 24) {
        switch (time) {
            case "Morning":
            case "Evening":
                outfit = "Shirt";
                shoes = "Moccasins";
                break;
            case "Afternoon":
                outfit = "T-Shirt";
                shoes = "Sandals";
                break;
        }
    } else if (degrees >= 25) {
        switch (time) {
            case "Morning":
                outfit = "T-Shirt";
                shoes = "Sandals";
                break;
            case "Evening":
                outfit = "Shirt";
                shoes = "Moccasins";
                break;
            case "Afternoon":
                outfit = "Swim Suit";
                shoes = "Barefoot";
                break;
        }
    }

    console.log(`It's ${degrees} degrees, get your ${outfit} and ${shoes}.`);
}

summerOutfit(["16", "Morning"]);
summerOutfit(["22", "Afternoon"]);
summerOutfit(["28", "Evening"]);