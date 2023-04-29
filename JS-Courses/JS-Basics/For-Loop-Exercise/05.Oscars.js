function oscars(input) {
    let actorName = input[0];
    let academyPoints = Number(input[1]);
    let count = Number(input[2]);

    let tototalPoints = 0.0;
    for (let i = 3; i < input.length; i += 2) {
        let name = input[i];
        let points = Number(input[i + 1]);

        let namelength = Number(name.length);
        tototalPoints = academyPoints + ((namelength * points) / 2);
        academyPoints = tototalPoints;

        if (tototalPoints > 1250.5) {
            console.log(`Congratulations, ${actorName} got a nominee for leading role with ${(tototalPoints).toFixed(1)}!`);
            return;
        }
    }

    console.log(`Sorry, ${actorName} you need ${(1250.5 - tototalPoints).toFixed(1)} more!`);
}

oscars(["Zahari Baharov",
    "205",
    "4",
    "Johnny Depp",
    "45",
    "Will Smith",
    "29",
    "Jet Lee",
    "10",
    "Matthew Mcconaughey",
    "39"
]);
oscars(["Sandra Bullock",
    "340",
    "5",
    "Robert De Niro",
    "50",
    "Julia Roberts",
    "40.5",
    "Daniel Day-Lewis",
    "39.4",
    "Nicolas Cage",
    "29.9",
    "Stoyanka Mutafova",
    "33"
]);

