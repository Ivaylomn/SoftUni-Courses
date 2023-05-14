function wordTracker(input) {
    let obj = {};
    let firstsEle = input.shift().split(' ');
    for (const el of firstsEle) {
        obj[el] = 0;
    }
    for (const el of input) {
        if (obj.hasOwnProperty(el)) {
            obj[el]++;
        }
    }
    Object.entries(obj).sort((a, b) => b[1] - a[1]).forEach(el => console.log(`${el[0]} - ${el[1]}`));
}

wordTracker([
    'this sentence', 'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurances', 'of', 'the'
    , 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]);