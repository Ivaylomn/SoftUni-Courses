function repeatString(text, countRepeat) {
    let result = '';
    for (let i = 0; i < countRepeat; i++) {
        result += text;
    }
    return result;
}

console.log(repeatString('abc', 3));
console.log(repeatString('String', 2));