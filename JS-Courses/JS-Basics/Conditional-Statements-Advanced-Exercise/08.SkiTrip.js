function skiTrip(input) {
    let daysStay = Number(input[0]);
    let room = input[1];
    let rating = input[2];

    daysStay -= 1;
    let pricePerNight = 0;
    let discount = 0;
    let totalSum = 0;

    switch (room) {
        case "room for one person":
            pricePerNight = 18.00;
            totalSum = daysStay * pricePerNight;
            discount = totalSum;
            break;
        case "apartment":
            pricePerNight = 25.00;
            if (daysStay < 10) {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 30 / 100;
                totalSum = discount;
            } else if (daysStay >= 10 && daysStay <= 15) {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 35 / 100;
                totalSum = discount;
            } else {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 50 / 100;
                totalSum = discount;
            }
            break;
        case "president apartment":
            pricePerNight = 35.00;
            if (daysStay < 10) {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 10 / 100;
                totalSum = discount;
            } else if (daysStay >= 10 && daysStay <= 15) {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 15 / 100;
                totalSum = discount;
            } else {
                totalSum = daysStay * pricePerNight;
                discount = totalSum - totalSum * 20 / 100;
                totalSum = discount;
            }
            break;
        default:
            break;

    }
    if (rating == "positive") {
        totalSum += discount * 25 / 100;
    } else {
        totalSum -= discount * 10 / 100;
    }

    console.log(`${totalSum.toFixed(2)}`);
}

skiTrip(["14","apartment","positive"]);
skiTrip(["30","president apartment","negative"]);
skiTrip(["12","room for one person","positive"]);
skiTrip(["2","apartment","positive"]);
