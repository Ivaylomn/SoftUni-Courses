function examPreparation(input) {
    let poorGrade = Number(input[0]);
    let index = 1;
    let command = input[index];
    let problemsCount = 0;
    let allGradeCount = 0;
    let sum = 0.0;
    while (command !== "Enough") {
        let grade = Number(input[index + 1]);
        sum += grade;
        allGradeCount++;
        if (problemsCount === poorGrade) {
            console.log(`You need a break, ${problemsCount} poor grades.`);
            return;
        }
        if (grade <= 4) {
            problemsCount++;
        }
        index += 2;
        command = input[index];
    }

    console.log(`Average score: ${(sum / allGradeCount).toFixed(2)}`);
    console.log(`Number of problems: ${allGradeCount}`);
    console.log(`Last problem: ${input[index - 2]}`);
}

examPreparation(["3",
    "Money",
    "6",
    "Story",
    "4",
    "Spring Time",
    "5",
    "Bus",
    "6",
    "Enough"
]);
examPreparation(["2",
    "Income",
    "3",
    "Game Info",
    "6",
    "Best Player",
    "4"
]);

