function solve(input) {
    let myMap = new Map();
    for (const el of input) {
        if (!myMap.has(el)) {
            myMap.set(el, 0);
        }
        let count = myMap.get(el)
        myMap.set(el, count + 1);
    }
    let sorted = Array.from(myMap).sort((a, b) => b[1] - a[1]);
    for (const [key, value] of sorted) {
        console.log(`${key} -> ${value} times`);
    }
    //And way for sort and print on one line-?
    Array.from(myMap).sort((a, b) => b[1] - a[1]).forEach(x => console.log(`${x[0]} -> ${x[1]} times`));
}

solve(["Here", "is", "the", "first", "sentence", "Here", "is", "another", "sentence", "And", "finally", "the", "third", "sentence"]);