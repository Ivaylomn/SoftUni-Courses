function tennisRanklist(input) {
    let tournamentsCount = Number(input[0]);
    let startPointInRanklist = Number(input[1]);

    let points = 0;
    let count = 0;
    for (let i = 2; i < tournamentsCount + 2; i++) {
        let stageReachedInTour = input[i];

        if (stageReachedInTour === "W") {
            points += 2000;
            count++;
        } else if (stageReachedInTour === "F") {
            points += 1200;
        } else if (stageReachedInTour === "SF") {
            points += 720;
        }
    }

    let totalPoints = points + startPointInRanklist;
    console.log(`Final points: ${totalPoints}`);
    console.log(`Average points: ${Math.floor(points / tournamentsCount)}`);
    console.log(`${(count / tournamentsCount * 100).toFixed(2)}%`);
}

tennisRanklist(["5",
    "1400",
    "F",
    "SF",
    "W",
    "W",
    "SF"
]);
tennisRanklist(["4",
    "750",
    "SF",
    "W",
    "SF",
    "W"
]);
tennisRanklist(["7",
    "1200",
    "SF",
    "F",
    "W",
    "F",
    "W",
    "SF",
    "W"
]);