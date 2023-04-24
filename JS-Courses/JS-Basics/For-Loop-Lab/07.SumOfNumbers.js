function SumOfNumbers(input){
    let num = input[0];

    let sum = 0;
    for (let i = 0; i < num.length; i++) {
        sum += Number(num[i]);
    }

    console.log(`The sum of the digits is:${sum}`);
}

SumOfNumbers(["1234"]);
SumOfNumbers(["564891"]);