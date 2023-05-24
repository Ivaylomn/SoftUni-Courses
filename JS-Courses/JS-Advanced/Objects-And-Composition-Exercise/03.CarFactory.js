function carFactory(obj) {
    let volume;
    if (obj.power <= 90) {
        obj.power = 90;
        volume = 1800;
    } else if (obj.power > 90 && obj.power <= 120) {
        obj.power = 120;
        volume = 2400;
    } else if (obj.power > 120 && obj.power <= 200) {
        obj.power = 200;
        volume = 3500;
    }
    let wheels = [];
    for (let i = 0; i < 4; i++) {
        if (obj.wheelsize % 2 === 0) {
            obj.wheelsize--;
        }
        wheels.push(obj.wheelsize);
    }
    let car = {
        model: obj.model,
        engine: {
            power: obj.power,
            volume
        },
        carriage: {
            type: obj.carriage,
            color: obj.color
        },
        wheels
    }
    return car
}
let car = {
    model: 'VW Golf II',
    power: 90,
    color: 'blue',
    carriage: 'hatchback',
    wheelsize: 14
};
let carTwo = {
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
};

console.log(carFactory(car));
console.log(carFactory(carTwo));
