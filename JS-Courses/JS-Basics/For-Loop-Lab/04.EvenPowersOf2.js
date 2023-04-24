function evenPowersOf2(input) {
    let num = Number(input[0]);

    for (let i = 0; i <= num; i++) {
        if (i % 2 === 0){
            console.log(Math.pow(2, i));
        }
    }
}

evenPowersOf2(["3"]);
evenPowersOf2(["4"]);
evenPowersOf2(["5"]);
evenPowersOf2(["6"]);
evenPowersOf2(["7"]);