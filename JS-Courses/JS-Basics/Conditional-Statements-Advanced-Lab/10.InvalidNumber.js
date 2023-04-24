function invalidNumber(input) {
    let number = Number(input);

    if ((number < 100 || number > 200) && number !== 0){
        console.log("invalid");
    } else {
        console.log("");
    }
}

invalidNumber(["75"]);
invalidNumber(["150"]);
invalidNumber(["220"]);
invalidNumber(["199"]);
invalidNumber(["-1"]);
invalidNumber(["100"]);
invalidNumber(["200"]);
invalidNumber(["0"]);