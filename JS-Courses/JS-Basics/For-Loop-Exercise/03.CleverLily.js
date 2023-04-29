function cleverLily(input) {
    let lilyAge = Number(input[0]);
    let washingMachinePrice = Number(input[1]);
    let priceForToy = Number(input[2]);
    
    let toys = 0;
    let Gift = 0;
    let money = 10;
    for (let i = 1; i <= lilyAge; i++) {
        if (i % 2 == 0) {
            Gift += money;
            Gift--;
            money += 10;
        } else {
            toys++;
        }
    }

    let priceFromToys = toys * priceForToy;
    let totalMoney = priceFromToys + Gift;

    if (totalMoney < washingMachinePrice){
        console.log(`No! ${(washingMachinePrice - totalMoney).toFixed(2)}`);
    } else {
        console.log(`Yes! ${(totalMoney - washingMachinePrice).toFixed(2)}`);
    }
}

cleverLily(["10","170.00","6"]);
cleverLily(["21","1570.98","3"]);