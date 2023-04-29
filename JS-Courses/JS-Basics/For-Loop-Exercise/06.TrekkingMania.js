function trekkingMania(input) {
    let peopleCount = Number(input[0]);

    let musalaGroup = 0;
    let monblanGroup = 0;
    let kilimindjaroGroup = 0;
    let k2Group = 0;
    let everestGroup = 0;
    let totalPerson = 0;
    for (let i = 1; i < peopleCount + 1; i++) {
        let groupCount = Number(input[i]);

        totalPerson += groupCount;
        if (groupCount <= 5) {
            musalaGroup += groupCount;
        } else if (groupCount >= 6 && groupCount <= 12) {
            monblanGroup += groupCount;
        } else if (groupCount >= 13 && groupCount <= 25) {
            kilimindjaroGroup += groupCount;
        } else if (groupCount >= 26 && groupCount <= 40) {
            k2Group += groupCount;
        } else if (groupCount >= 41) {
            everestGroup += groupCount;
        }
    }

    console.log(`${(musalaGroup / totalPerson * 100).toFixed(2)}%`);
    console.log(`${(monblanGroup / totalPerson * 100).toFixed(2)}%`);
    console.log(`${(kilimindjaroGroup / totalPerson * 100).toFixed(2)}%`);
    console.log(`${(k2Group / totalPerson * 100).toFixed(2)}%`);
    console.log(`${(everestGroup / totalPerson * 100).toFixed(2)}%`);
}

trekkingMania(["10",
    "10",
    "5",
    "1",
    "100",
    "12",
    "26",
    "17",
    "37",
    "40",
    "78"
]);
trekkingMania(["5",
    "25",
    "41",
    "31",
    "250",
    "6"
]);

