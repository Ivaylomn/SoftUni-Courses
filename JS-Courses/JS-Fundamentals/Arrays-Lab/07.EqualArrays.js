function equalArrays(arrOne, arrTwo) {
    let sum = 0;
    for (let i = 0; i < arrOne.length; i++) {
        if(arrOne[i] === arrTwo[i]){
            sum += Number(arrOne[i]);
        } else {
            console.log(`Arrays are not identical. Found difference at ${i} index`);
            return;
        }
    }

    console.log(`Arrays are identical. Sum: ${sum}`);
}

equalArrays(['10','20','30'], ['10','20','30']);
equalArrays(['1','2','3','4','5'], ['1','2','4','4','5']);
equalArrays(['1'], ['10']);
