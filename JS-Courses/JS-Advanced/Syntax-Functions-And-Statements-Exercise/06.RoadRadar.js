function roadRadar(speed, place) {
    let maxSpeed;
    switch (place) {
        case 'residential':
            maxSpeed = 20;
            break;
        case 'city':
            maxSpeed = 50;
            break;
        case 'interstate':
            maxSpeed = 90;
            break;
        case 'motorway':
            maxSpeed = 130;
    }
    if (speed <= maxSpeed) {
        console.log(`Driving ${speed} km/h in a ${maxSpeed} zone`);
    } else {
        if (speed - maxSpeed > 0 && speed - maxSpeed <= 20) {
            console.log(`The speed is ${speed - maxSpeed} km/h faster than the allowed speed of ${maxSpeed} - speeding`);
        } else if (speed - maxSpeed > 20 && speed - maxSpeed <= 40) {
            console.log(`The speed is ${speed - maxSpeed} km/h faster than the allowed speed of ${maxSpeed} - excessive speeding`);
        } else {
            console.log(`The speed is ${speed - maxSpeed} km/h faster than the allowed speed of ${maxSpeed} - reckless driving`);
        }
    }
}
roadRadar(40, 'city');
roadRadar(21, 'residential');
roadRadar(120, 'interstate');
roadRadar(200, 'motorway');