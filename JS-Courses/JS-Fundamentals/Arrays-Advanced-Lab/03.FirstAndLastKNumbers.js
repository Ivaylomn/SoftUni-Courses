function solve(arr) {
    let k = arr.shift();
    let firsNumber = arr.slice(0, k).join(' ');
    let lastNumber = arr.slice(arr.length - k, arr.length).join(' ');
    console.log(firsNumber);
    console.log(lastNumber);
}

solve([2, 7, 8, 9]);
solve([3, 6, 7, 8, 9]);