function bonusScore(input) {
    let number = Number(input[0]);
    let result = 0;
    if (number <= 100) {
        result += 5;
    } else if (number > 100 && number <= 1000) {
        result += number * 20 / 100;
    }else if (number > 1000){
        result += number * 0.10;
    }
    
    if (number % 2 == 0) {
        result += 1;
    }else if (number % 10 === 5) {
        result += 2;
    }

    console.log(result);
    console.log(number + result);
}

bonusScore(["20"]);
bonusScore(["175"]);
bonusScore(["2703"]);
bonusScore(["15875"]);
