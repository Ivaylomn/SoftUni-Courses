function graduation(input) {
    let name = input[0];

    let index = 1;
    let count = 0;
    let sum = 0.0;
    let grade = Number(input[index]);
    while (grade !== 2) {
        if (grade >= 4) {
            count++;
            sum += grade;
        }

        if (count >= 12) {
            let averageGrade = sum / count
            console.log(`${name} graduated. Average grade: ${averageGrade.toFixed(2)}`);
            return;
        }
        index++
        grade = Number(input[index]);
    }

    console.log(`${name} has been excluded at ${count + 1} grade`)
}

graduation(["Gosho",
    "5",
    "5.5",
    "6",
    "5.43",
    "5.5",
    "6",
    "5.55",
    "5",
    "6",
    "6",
    "5.43",
    "5"
]);
graduation(["Mimi",
    "5",
    "6",
    "5",
    "6",
    "5",
    "6",
    "6",
    "2",
    "3"
]);

