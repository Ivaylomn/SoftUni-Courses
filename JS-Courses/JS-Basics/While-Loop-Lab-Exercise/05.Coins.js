function coins(input) {
    let amountRemainder = Number(input[0]);
    let cents = Math.round(amountRemainder * 100, 2);
    let count = 0;
    while (cents > 0) {
        if (cents >= 200) {
            count++; 
            cents -= 200;
        }else if (cents >= 100) {
            count++; 
            cents -= 100;
        }else if (cents >= 50) {
            count++; 
            cents -= 50;
        }else if (cents >= 20) {
            count++; 
            cents -= 20;
        }else if (cents >= 10) {
            count++; 
            cents -= 10;
        }else if (cents >= 5) {
            count++; 
            cents -= 5;
        }else if (cents >= 2) {
            count++; 
            cents -= 2;
        }else if (cents >= 1) {
            count++; 
            cents -= 1;
        }
    }

    console.log(count);
}

coins(["1.23"]);
coins(["2"]);
coins(["0.56"]);
coins(["2.73"]);