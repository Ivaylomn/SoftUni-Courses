function solve(arr, step) {
    let newArr = []
    for (let i = 0; i < arr.length; i += step) {
        newArr.push(arr[i]);
    }
    return newArr;
}
console.log(solve(['5',
    '20',
    '31',
    '4',
    '20'],
    2
));
console.log(solve(['1',
    '2',
    '3',
    '4',
    '5'],
    6
));