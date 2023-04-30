function walking(input) {
    let index = 0;
    let totalSteps = 0;
    while (totalSteps < 10000) {
        let steps = Number(input[index]);
        let command = input[index];
        if (command === "Going home") {
            totalSteps += Number(input[index + 1]);
            break;
        }
        totalSteps += steps;
        index++;
        command = input[index];
    }
    //Solution with ternary operator!!
    console.log(totalSteps < 10000 ? `${10000 - totalSteps} more steps to reach goal.` 
    : `Goal reached! Good job!\n${totalSteps - 10000} steps over the goal!`);
    
    // if (totalSteps > 10000) {
    //     console.log("Goal reached! Good job!");
    //     console.log(`${totalSteps - 10000} steps over the goal!`)
    // } else {
    //     console.log(`${Math.abs(10000 - totalSteps)} more steps to reach goal.`);
    // }
}

walking(["1000", "1500", "2000", "6500"]);
walking(["1500", "300", "2500", "3000", "Going home", "200"]);
walking(["1500","3000", "250","1548","2000","Going home","2000"]);
walking(["125", "250", "4000", "30", "2678", "4682"]);