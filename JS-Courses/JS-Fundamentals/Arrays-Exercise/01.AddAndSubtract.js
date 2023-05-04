function addAndSubstract(array) {
    let originalSum = array.reduce((a, b) => a + b, 0);
    let changedSum = 0;
    for (let i = 0; i < array.length; i++) {
        if (array[i] % 2 === 0) {
            array[i] += i;
            changedSum += array[i];
        } else {
            array[i] -= i;
            changedSum += array[i];
        }
    }
    console.log(array);
    console.log(originalSum);
    console.log(changedSum);
    //console.log(array.reduce((a, b) => a + b));
}

addAndSubstract([5, 15, 23, 56, 35]);