function solve(input){
    let name = input[0];
    let countOfProjects = Number(input[1]);
    let needHours = countOfProjects * 3;
    console.log(`The architect ${name} will need ${needHours} hours to complete ${countOfProjects} project/s.`);
}

solve(["Ivaylo", "9"]);