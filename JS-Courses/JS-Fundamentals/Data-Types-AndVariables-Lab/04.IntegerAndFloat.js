function integerAndFloat(numOne, numTwo, numThree) {
    let sum = numOne + numThree + numTwo;
    if (Math.trunc(sum) == sum) {
        sum += ' - Integer';
    }else {
        sum += ' - Float';
    }

    console.log(sum);

    //And other way to solution our promlem->
    // if(sum % 1 === 0) {
    //     sum += ' - Integer';
    // }else {
    //     sum += ' - Float';
    // }
    // console.log(sum);

    //One more way to solution the problem with ternary operator->
    // sum % 1 === 0 ? sum += ' - Integer' : sum += ' - Float';
    // console.log(sum)
}

integerAndFloat(9, 100, 1.1);
integerAndFloat(100, 200, 303);