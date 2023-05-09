function listOfProduct(arr) {
    arr.sort((a,b) => a.localeCompare(b));
    let count = 1;
    for (let el of arr) {
        console.log(`${count++}.${el}`);
    }
}

listOfProduct(["Potatoes", "Tomatoes", "Onions", "Apples"]);