function squareOfStars(size) {
    for (let i = 0; i < size; i++) {
        console.log('* '.repeat(size).trimEnd());      
    }
}
squareOfStars(1);
squareOfStars(2);
squareOfStars(5);
squareOfStars(7);