function vowelsSum(input) {
    let text = String(input[0]);

    let sum = 0;
    for (let i = 0; i < text.length; i++) {
        let letter = text[i];

        if (letter === "a"){
            sum += 1;
        } else if (letter ===  "e"){
            sum += 2;
        } else if (letter ===  "i"){
            sum += 3;
        } else if (letter ===  "o"){
            sum += 4;
        } else if (letter ===  "u"){
            sum += 5;
        }
    }

    console.log(sum);
}

vowelsSum(["hello"]);
vowelsSum(["hi"]);
vowelsSum(["bamboo"]);
vowelsSum(["beer"]);