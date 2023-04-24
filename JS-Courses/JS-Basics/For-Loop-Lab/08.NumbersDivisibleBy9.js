function numbersDivisibleBy9(input){
    let numOne = Number(input[0]);
    let numTwo = Number(input[1]);

    let sum = 0;
    let output = "";
    for (let i = numOne; i < numTwo; i++) {
        if (i % 9 == 0){
            sum += i;
            output += i + "\n";
        }
    }      

    console.log(`The sum is: ${sum}`);
    console.log(output);
}

numbersDivisibleBy9(["100", "200"]);