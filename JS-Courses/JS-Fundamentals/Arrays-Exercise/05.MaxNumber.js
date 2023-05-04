function maxNumber(arr) {
    let output = '';
    for (let i = 0; i < arr.length; i++) {
        let currentNumber = arr[i];
        let isTopIntiger = true;

        for (let j = i + 1; j < arr.length; j++) {
            if (arr[j] >= currentNumber) {
                isTopIntiger = false;
                break;
            }
        }
        if (isTopIntiger) {
            output += currentNumber + ' ';
        }
    }
    console.log(output.trimEnd());
}

maxNumber([1, 4, 3, 2]);
maxNumber([14, 24, 3, 19, 15, 17]);
maxNumber([41, 41, 34, 20]);
maxNumber([27, 19, 42, 2, 13, 45, 48]);