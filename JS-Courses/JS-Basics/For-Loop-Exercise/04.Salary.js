function salary(input) {
    let openTabsCount = Number(input[0]);
    let salary = Number(input[1]);


    for (let i = 2; i <= input.length; i++) {
        let browser = String(input[i]);

        if (browser === "Facebook") {
            salary -= 150;
        } else if (browser === "Instagram") {
            salary -= 100;
        } else if (browser === "Reddit") {
            salary -= 50;
        }

        if (salary <= 0) {
            console.log("You have lost your salary.");
            return;
        }
    }

    console.log(salary);
}

salary(["10", "750", "Facebook", "Dev.bg", "Instagram", "Facebook", "Reddit", "Facebook", "Facebook"]);
salary(["3", "500", "Github.com", "Stackoverflow.com", "softuni.bg"]);
salary(["3", "500", "Facebook", "Stackoverflow.com", "softuni.bg"]);

