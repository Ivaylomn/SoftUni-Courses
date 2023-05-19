function sumFirstAndLast(arr) {
    return Number(arr.shift()) + Number(arr.pop());
}
console.log(sumFirstAndLast(['20', '30', '40']));
console.log(sumFirstAndLast(['5', '10']));