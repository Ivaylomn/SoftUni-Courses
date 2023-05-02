function requiredReading(pagesCount, readPageForHour, daysCount) {
    let timeForreadingBook = pagesCount / readPageForHour;
    let result = timeForreadingBook / daysCount;
    console.log(result);
}

requiredReading(212,
    20,
    2);
requiredReading(432,
    15,
    4
);