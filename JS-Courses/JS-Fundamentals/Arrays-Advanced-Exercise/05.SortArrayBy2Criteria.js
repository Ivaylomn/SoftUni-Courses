function sortArrayByTwoCriteria(array) {
    console.log(array.sort((a, b) => a.length - b.length || a.localeCompare(b)).join('\n'));
}

sortArrayByTwoCriteria(["alpha", "beta", "gamma"]);
sortArrayByTwoCriteria(["Isacc", "Theodor", "Jack", "Harrison", "George"]);