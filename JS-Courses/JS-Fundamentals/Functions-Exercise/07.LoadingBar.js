function loadingBar(num) {
    let percentages = '%'.repeat(num / 10);
    let dot = '.'.repeat(10 - num / 10);
    if (num === 100) {
        console.log(`${num}% Complete!`);
        console.log(`${num}% [${percentages}]`);
    } else {
        console.log(`${num}% [${percentages}${dot}]`);
        console.log('Still loading...');
    }
}

loadingBar(30);
loadingBar(50);
loadingBar(100);