function sumFirstAndLast(arr){
    let firstNumber = Number(arr.shift());
    let lastNumber = Number(arr.pop());
    return firstNumber + lastNumber;
}

console.log(sumFirstAndLast(['20', '30', '40']));
console.log(sumFirstAndLast(['5', '10']));