function vacation(people, groupType, day) {
    let price = 0;
    switch (groupType) {
        case "Students":
            switch (day) {
                case "Friday":
                    price = 8.45;
                    break;
                case "Saturday":
                    price = 9.80;
                    break;
                case "Sunday":
                    price = 10.46;
                    break;
            }
            break;
        case "Business":
            switch (day) {
                case "Friday":
                    price = 10.90;
                    break;
                case "Saturday":
                    price = 15.60;
                    break;
                case "Sunday":
                    price = 16.00;
                    break;
            }
            break;
        case "Regular":
            switch (day) {
                case "Friday":
                    price = 15.00;
                    break;
                case "Saturday":
                    price = 20.00;
                    break;
                case "Sunday":
                    price = 22.50;
                    break;
            }
            break;
    }
    let currantPeople = Number(people);
    let totalPrice = currantPeople * price;
    if (currantPeople >= 30 && groupType === "Students") {
        totalPrice -= totalPrice * 0.15;
    } else if (currantPeople >= 100 && groupType === "Business") {
        totalPrice = (people - 10) * price;
    } else if (currantPeople >= 10 && currantPeople <= 20 && groupType === "Regular") {
        totalPrice -= totalPrice * 0.05;
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}

vacation(30,
    "Students",
    "Sunday"
);
vacation(40,
    "Regular",
    "Saturday"
);