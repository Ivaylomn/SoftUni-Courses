function sumEvenNumbers(arr) {
    let sum = 0;
    for (const num of arr) {
        let currentNum = Number(num);
        if (currentNum % 2 === 0) {
            sum += currentNum;
        }
    }
    console.log(sum)
    /*Here We convert our array from string to number with method MAP()
    console.log(arr.map(i=>Number(i)));
    */
}

sumEvenNumbers(['1','2','3','4','5','6']);
sumEvenNumbers(['3','5','7','9']);
sumEvenNumbers(['2','4','6','8','10']);
