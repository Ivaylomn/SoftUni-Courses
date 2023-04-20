function worldSwimmingRecord(input) {
    let recordInSeconds = Number(input[0]);
    let meters = Number(input[1]);
    let timeInSecondsPerMeter = Number(input[2]);

    let totalDistance = meters * timeInSecondsPerMeter;
    let addSeconds = Math.floor(meters / 15) * 12.5;
    let totalTime = totalDistance + addSeconds;

    if (recordInSeconds <= totalTime) {
        console.log(`No, he failed! He was ${(totalTime - recordInSeconds).toFixed(2)} seconds slower.`)
    } else if (recordInSeconds > totalTime) {
        console.log(`Yes, he succeeded! The new world record is ${(totalTime).toFixed(2)} seconds.`)
    }
}

//worldSwimmingRecord(["10464", "1500", "20"]);
worldSwimmingRecord(["55555.67", "3017", "5.03"]);
