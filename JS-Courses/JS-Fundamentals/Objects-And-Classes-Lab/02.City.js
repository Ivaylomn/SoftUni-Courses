function city(obj) {
    for (const [key, value] of Object.entries(obj)) {
        console.log(`${key} -> ${value}`);
    }

    /* Or other Way->
    for (const key of Object.keys(input)) {
        console.log(`${key} -> ${input[key]}`);
    }
    */
}

city(
    {
        name: "Sofia",
        area: 492,
        population: 1238438,
        country: "Bulgaria",
        postCode: "1000"
    });