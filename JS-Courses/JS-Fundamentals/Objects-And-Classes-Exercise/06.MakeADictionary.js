function makeADictionary(arr) {
    let obj = {};
    let copy = [];
    for (const el of arr) {
        let jsonToObj = JSON.parse(el);
        if (typeof jsonToObj === 'object') {
            for (const key in jsonToObj) {
                obj[key] = jsonToObj[key];
            }
        }
    }
    for (const key in obj) {
        copy.push(`Term: ${key} => Definition: ${obj[key]}`);
    }
    console.log(copy.sort().join('\n'));
}

makeADictionary([
    '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'
]);