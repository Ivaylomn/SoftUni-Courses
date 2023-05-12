function isPalindrom(arr) {
    let result = '';
    for (let el of arr) {
        let isPolindrom = 'true';
        let str = el.toString()
        let reversedStr = str.split('').reverse().join('');
        isPolindrom = str === reversedStr ? 'true' : 'false'; 
        // let mid = parseInt(el.length / 2);
        // for (let i = 0; i <= mid; i++) {
        //     if (el[i] !== el[el.length - 1 - i]) {
        //         isPolindrom = 'false';
        //         break;
        //     }
        // }
        result += isPolindrom + '\n';
    }
    return result
}

console.log(isPalindrom([123, 323, 421, 121]));
console.log(isPalindrom([32, 2, 232, 1010]));