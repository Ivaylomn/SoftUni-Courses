function solve(arr) {
    let newArray = [];
    for (const el of arr) {
        if (el < 0) {
            newArray.unshift(el);
        } else {
            newArray.push(el);
        }
    }

    return newArray.join('\n');
}

console.log(solve([7, -2, 8, 9]));
console.log(solve([3, -2, 0, -1]));