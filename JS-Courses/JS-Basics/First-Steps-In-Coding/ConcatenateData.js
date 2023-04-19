function solve(input){
    let firstName = input[0];
    let lastName = input[1];
    let years = input[2];
    let town = input[3];
    console.log(`You are ${firstName} ${lastName}, a ${years}-years old person from ${town}.`);
}

solve(["Ivaylo", "Ninov", "30", "Vidin"]);