function newHouse(input) {
    let flowers = input[0];
    let flowersCount = Number(input[1]);
    let budget = Number(input[2]);

    let rosse = 5.0, Dahlia = 3.80, Tulip = 2.80, Narcissus = 3.0, Gladiola = 2.50;
    let totalPrice = 0.0;
    switch (flowers) {
        case "Roses":
            totalPrice = flowersCount * rosse;
            if (flowersCount > 80) {
                totalPrice -= totalPrice * 0.10;
            } 
            break;
        case "Dahlias":
            totalPrice = flowersCount * Dahlia;
            if (flowersCount > 90) {
                totalPrice -= totalPrice * 0.15;
            } 
            break;
        case "Tulips":
            totalPrice = flowersCount * Tulip;
            if (flowersCount > 80) {
                totalPrice -= totalPrice * 0.15;
            } 
            break;
        case "Narcissus":
            totalPrice = flowersCount * Narcissus;
            if (flowersCount < 120) {
                totalPrice += totalPrice * 0.15;
            } 
            break;
        case "Gladiolus":
            totalPrice = flowersCount * Gladiola;
            if (flowersCount < 80) {
                totalPrice += totalPrice * 0.20;
            } 
            break;
    }

    if (budget < totalPrice) {
        console.log(`Not enough money, you need ${(totalPrice - budget).toFixed(2)} leva more.`);
    } else if (budget >= totalPrice) {
        console.log(`Hey, you have a great garden with ${flowersCount} ${flowers} and ${(budget - totalPrice).toFixed(2)} leva left.`);
    }
}

newHouse(["Roses","55","250"]);
newHouse(["Tulips","88","260"]);
newHouse(["Narcissus","119","360"]);

