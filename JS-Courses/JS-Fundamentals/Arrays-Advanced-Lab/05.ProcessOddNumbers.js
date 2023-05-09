function processOdNumbers(arr) {
    console.log(arr
        .filter((v, i) => i % 2 === 1)
        .map(x => x * 2)
        .reverse()
        .join(' '));
}

processOdNumbers([10, 15, 20, 25]);
processOdNumbers([3, 0, 10, 4, 7, 3]);