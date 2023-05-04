function mergeArrays(firstArr, secondArr) {
    let thirdArr = [];
    for (let i = 0; i < firstArr.length; i++) {
        if (i % 2 === 0) {
            thirdArr.push(Number(firstArr[i]) + Number(secondArr[i]));
        } else {
            thirdArr.push(firstArr[i] + secondArr[i])
        }
    }

    console.log(thirdArr.join(' - '));
}

mergeArrays(['5', '15', '23', '56', '35'],
['17', '22', '87', '36', '11']
);
mergeArrays(['13', '12312', '5', '77', '4'],
['22', '333', '5', '122', '44']
);