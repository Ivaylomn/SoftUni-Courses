function numbersNTo1(input){
    let number  = Number(input[0]);

    for (let i = number; i > 0; i--) {
        console.log(i)
    }      
}

numbersNTo1(["2"]);
numbersNTo1(["3"]);
numbersNTo1(["5"]);