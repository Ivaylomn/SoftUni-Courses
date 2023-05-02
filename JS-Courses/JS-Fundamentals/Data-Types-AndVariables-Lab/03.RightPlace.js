function rightPlace(string, char, rightString) {
    let newString = string.replace('_', char);
    if (newString === rightString) {
        console.log('Matched');
    }else {
        console.log('Not Matched');
    }
}

rightPlace('Str___ng', 'I', 'Strong');
rightPlace('Str_ng', 'i', 'String');