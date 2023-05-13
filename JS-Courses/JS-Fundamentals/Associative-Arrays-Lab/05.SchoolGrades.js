function schoolGrade(input) {
    let myMap = new Map();
    for (const line of input) {
        let [name, ...grades] = line.split(' ')
        if (!myMap.has(name)) {
            myMap.set(name, []);
        }
        for (const el of grades) {
            myMap.get(name).push(Number(el));
        }
    }
    let sortedMap = Array.from(myMap.entries()).sort((a, b) => a[0].localeCompare(b[0]));
    for (const [key, value] of sortedMap) {
        console.log(`${key}: ${(value.reduce((p, c) => p + c, 0) / value.length).toFixed(2)}`);
    }
    
    // function average(a, b) {
    //     // let avrA = 0;
    //     // a[1].forEach(x => avrA += x);
    //     // avrA /= a[1].length;
    //     // let avrB = 0;
    //     // b[1].forEach(x => avrB += x);
    //     // avrB /= b[1].length;

    //     //Solution with reduce->
    //     let avrA = a[1].reduce((p, c) => p + c, 0) / a[1].length;
    //     let avrB = b[1].reduce((p, c) => p + c, 0) / b[1].length;
    //     return avrA - avrB;
    // }
}

schoolGrade(['Lilly 4 6 6 5',
    'Tim 5 6',
    'Tammy 2 4 3',
    'Tim 6 6'
]);