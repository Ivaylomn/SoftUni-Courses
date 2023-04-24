function animalType(input) {
    let animal = input[0];

    switch (animal) {
        case "dog":
            console.log("mammal");
            break;
        case "snake":
        case "crocodile":
        case "tortoise":
            console.log("reptile");
            break;
        default:
            console.log("unknown");
            break;
    }
}

animalType(["dog"]);
animalType(["snake"]);
animalType(["cat"]);