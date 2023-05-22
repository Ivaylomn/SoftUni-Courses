function solve(array){
    let rezult = Math.ceil(array.length / 2);
    if(array.length % 2 !== 0){
        rezult -= 1;
    }
    let sortedArray = array.sort((a, b) => a - b).slice(rezult);

    return sortedArray;
}
console.log(solve([4, 7, 2, 5]));
console.log(solve([3, 19, 14, 7, 2, 19, 6, 12]));