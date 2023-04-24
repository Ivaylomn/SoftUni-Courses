function tradeCommissions(input) {
    let town = input[0];
    let volumeSelling = Number(input[1]);

    let commissions = 0.0;
    let isValid = true;
    switch (town) {
        case "Sofia":
            if (volumeSelling >= 0 && volumeSelling <= 500) {
                commissions = volumeSelling * 0.05;
            } else if (volumeSelling > 500 && volumeSelling <= 1000) {
                commissions = volumeSelling * 0.07;
            } else if (volumeSelling > 1000 && volumeSelling <= 10000) {
                commissions = volumeSelling * 0.08;
            } else if (volumeSelling > 10000) {
                commissions = volumeSelling * 0.12;
            } else {
                isValid = false;
            }
            break;
        case "Varna":
            if (volumeSelling >= 0 && volumeSelling <= 500) {
                commissions = volumeSelling * 0.045;
            } else if (volumeSelling > 500 && volumeSelling <= 1000) {
                commissions = volumeSelling * 0.075;
            } else if (volumeSelling > 1000 && volumeSelling <= 10000) {
                commissions = volumeSelling * 0.10;
            } else if (volumeSelling > 10000) {
                commissions = volumeSelling * 0.13;
            } else {
                isValid = false;
            }
            break;
        case "Plovdiv":
            if (volumeSelling >= 0 && volumeSelling <= 500) {
                commissions = volumeSelling * 0.055;
            } else if (volumeSelling > 500 && volumeSelling <= 1000) {
                commissions = volumeSelling * 0.08;
            } else if (volumeSelling > 1000 && volumeSelling <= 10000) {
                commissions = volumeSelling * 0.12;
            } else if (volumeSelling > 10000) {
                commissions = volumeSelling * 0.145;
            } else {
                isValid = false;
            }
            break;
        default:
            isValid = false;
            break;
    }

    if (isValid === true) {
        console.log(commissions.toFixed(2));
    } else {
        console.log("error");
    }
}

tradeCommissions(["Sofia", "1500"]);
tradeCommissions(["Plovdiv", "499.99"]);
tradeCommissions(["Varna", "3874.50"]);
tradeCommissions(["Kaspichan", "-50"]);