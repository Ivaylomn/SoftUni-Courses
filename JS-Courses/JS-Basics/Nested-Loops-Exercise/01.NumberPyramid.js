function piramid(input) {
    let num = Number(input[0]);
    let current = 1;
    let isBigger = false;
    for (let i = 1; i <= num; i++) {
        let output = "";
        for (let j = 1; j <= i; j++) {
            if (current > num) {
                isBigger = true;
                break;
            }
            output += current + " ";
            current++;
        }
        console.log(output);
        if (isBigger){
            break;
        }
    }
}

piramid(["7"])