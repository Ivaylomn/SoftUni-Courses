function evenPosition(arr){
    console.log(arr.filter((v, i) => i % 2 === 0).join(' '));
}
evenPosition(['20', '30', '40', '50', '60']);
evenPosition(['5', '10']);