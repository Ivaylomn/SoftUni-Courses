function theatrePromotion(day, age) {
    let price = 0;
    switch (day) {
        case "Weekday":
            if (age >= 0 && age <= 18) {
                price = 12;
            } else if (age > 18 && age <= 64) {
                price = 18;
            } else if (age > 64 && age <= 122) {
                price = 12
            } else {
                console.log("Error!");
                return;
            }
            break;
        case "Weekend":
            if (age >= 0 && age <= 18) {
                price = 15;
            } else if (age > 18 && age <= 64) {
                price = 20;
            } else if (age > 64 && age <= 122) {
                price = 15
            } else {
                console.log("Error!");
                return;
            }
            break;
        case "Holiday":
            if (age >= 0 && age <= 18) {
                price = 5;
            } else if (age > 18 && age <= 64) {
                price = 12;
            } else if (age > 64 && age <= 122) {
                price = 10
            } else {
                console.log("Error!");
                return;
            }
            break;
    }

    console.log(price + "$");
}

theatrePromotion("Weekday", 42);
theatrePromotion('Holiday', -12);
theatrePromotion('Holiday', 15);