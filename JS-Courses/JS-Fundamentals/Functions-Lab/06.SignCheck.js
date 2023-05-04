function signCheck(a, b, c) {
    let devide = (a, b, c) => a * b * c;
    return devide(a, b, c) < 0 ? "Negative" : "Positive";
}

console.log(signCheck(5, 15, -15));
console.log(signCheck(-6, -12, 14));
console.log(signCheck(-1, -2, -3));