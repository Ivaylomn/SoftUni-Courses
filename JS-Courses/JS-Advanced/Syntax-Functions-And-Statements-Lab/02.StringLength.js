function stringLen(firstStr, secondStr, thirdStr) {
    let sum = firstStr.length + secondStr.length + thirdStr.length;
    console.log(sum);
    console.log(Math.floor(sum / 3));
}

stringLen('chocolate', 'ice cream', 'cake');
stringLen('pasta', '5', '22.3');