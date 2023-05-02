function echoType(input) {
    if(typeof(input) === "string"){
        console.log(typeof input);
        console.log(input);
    }else if (typeof(input) === "number"){
        console.log(typeof input);
        console.log(input);
    }else {
        console.log(typeof input);
        console.log('Parameter is not suitable for printing');
    }
}

echoType('Hello, JavaScript!');
echoType(18);
echoType(null);