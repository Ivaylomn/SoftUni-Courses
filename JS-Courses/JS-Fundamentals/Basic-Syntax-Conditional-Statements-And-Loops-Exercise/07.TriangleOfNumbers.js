function triangleOfNumbers(number) {
    let output = "";
    for (let i = 1; i <= number; i++) {
        for (let j = 1; j <= i; j++) {
            output += i + " ";
        }
        console.log(output.trimEnd());       
        output = "";
    }
}

triangleOfNumbers(3);
triangleOfNumbers(5);
triangleOfNumbers(6);