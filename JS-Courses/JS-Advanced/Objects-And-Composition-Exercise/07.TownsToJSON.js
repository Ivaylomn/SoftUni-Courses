function townsToJson(arr) {
    let info = [];
    for(let i = 1; i < arr.length; i++){
        let array = arr[i].split('|').filter(n => n);
        let obj = {
            Town: array[0].trim(),
            Latitude: Math.round((Number(array[1]) + Number.EPSILON) * 100) / 100,
            Longitude: Math.round((Number(array[2]) + Number.EPSILON) * 100) / 100
        }
        info.push(obj)
    }
    return JSON.stringify(info);
}
console.log(townsToJson(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |'
]));