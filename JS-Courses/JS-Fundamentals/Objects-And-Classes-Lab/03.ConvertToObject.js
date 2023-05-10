function convertToObject(jsonInput) {
    let convertJsonToObject = JSON.parse(jsonInput);
    let entries = Object.entries(convertJsonToObject);
    for (const [key, value] of entries) {
        console.log(`${key}: ${value}`);
    }
}

convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');