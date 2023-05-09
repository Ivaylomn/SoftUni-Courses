function searchForNumber(arrOne, arrTwo) {
    let newArray = arrOne.slice(0, arrTwo[0]);
    newArray = newArray.slice(arrTwo[1], newArray.length);
    let count = 0;
    newArray.forEach(element => {
        if (element === arrTwo[2]) {
            count++;
        }
    });
    console.log(`Number ${arrTwo[2]} occurs ${count} times.`);
}

searchForNumber([5, 2, 3, 4, 1, 6], [5, 2, 3]);