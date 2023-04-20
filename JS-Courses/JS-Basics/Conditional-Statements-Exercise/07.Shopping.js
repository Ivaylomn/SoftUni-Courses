function shopping(input) {
    let budget = Number(input[0]);
    let videoCards = Number(input[1]);
    let procesors = Number(input[2]);
    let ramMemory = Number(input[3]);

    let procesorPrice = videoCards * 250 * 0.35;
    let ramMemoryPrice = videoCards * 250 * 0.10;

    let totalPrice = videoCards * 250 + procesors * procesorPrice + ramMemory * ramMemoryPrice;

    if (videoCards > procesors) {
        totalPrice -= totalPrice * 0.15;
    }

    if (budget < totalPrice) {
        console.log(`Not enough money! You need ${(totalPrice - budget).toFixed(2)} leva more!`);
    } else {
        console.log(`You have ${(budget - totalPrice).toFixed(2)} leva left!`);
    }
}

shopping(["900", "2", "1", "3"]);
shopping(["920.45", "3", "1", "1"]);