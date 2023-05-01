function leapYear(year) {
    let currentYear = Number(year);
    if (currentYear % 4 === 0 || currentYear % 400 === 0) {
        console.log("yes")
    } else {
        console.log("no");
    }
}

leapYear(1900);
leapYear(1984);
leapYear(2003);
leapYear(4);