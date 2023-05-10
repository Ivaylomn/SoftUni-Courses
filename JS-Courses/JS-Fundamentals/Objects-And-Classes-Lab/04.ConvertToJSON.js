function convertToJSON(name, lastName, hairColor) {
    let personInfo = {
        name,
        lastName,
        hairColor
    };
    console.log(JSON.stringify(personInfo));
}

convertToJSON('George', 'Jones', 'Brown');