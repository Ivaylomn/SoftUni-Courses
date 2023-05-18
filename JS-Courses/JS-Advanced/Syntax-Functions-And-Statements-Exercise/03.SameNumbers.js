function sameNumbers(input) {
    let str = input.toString();
    let firstElement = str[0];
    let isSame = true;
    let sum = Number(firstElement);
    for (let i = 1; i < str.length; i++) {
        if (firstElement !== str[i]) {
            isSame = false;
        }
        sum += Number(str[i]);
    }
    console.log(isSame);
    console.log(sum);
}
sameNumbers(2222222);
sameNumbers(1234);