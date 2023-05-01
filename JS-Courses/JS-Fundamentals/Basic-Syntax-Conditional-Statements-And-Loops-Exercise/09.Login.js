function login(input) {
    let username = String(input[0]);
    let reversedPassword = username.split("").reverse().join("");
    let index = 1;
    let count = 0;
    while (count < 4) {
        let currentPassword = input[index];
        if (reversedPassword === currentPassword) {
            console.log(`User ${username} logged in.`);
            return;
        }else {
            if(count === 3){
                console.log(`User ${username} blocked!`);
                return;
            }
            console.log("Incorrect password. Try again.");
            currentPassword = input[index]
            count++
            index++;
        }
    }
}

login(['Acer','login','go','let me in','recA']);
login(['momo','omom']);
login(['sunny','rainy','cloudy','sunny','not sunny']);