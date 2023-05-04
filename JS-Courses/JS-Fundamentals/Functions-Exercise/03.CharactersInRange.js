function charactersInRange(charOne, charTwo) {
    let firstCode = charOne.charCodeAt();
    let secondCode = charTwo.charCodeAt();
    let start = Math.min(firstCode, secondCode);
    let end = Math.max(firstCode, secondCode);
    let output = '';
    for (let i = start + 1; i < end; i++) {
        output += String.fromCharCode(i) + ' ';
    }
    return output;
}

console.log(charactersInRange('a', 'b'));
console.log(charactersInRange('#', ':'));