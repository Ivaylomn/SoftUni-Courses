function hotelRoom(input) {
    let month = input[0];
    let nightsCount = Number(input[1]);

    let apertmentPrice = 0.0;
    let studioPrice = 0.0;
    switch (month) {
        case "May":
        case "October":
            apertmentPrice = 65;
            studioPrice = 50;
            if (nightsCount > 7 && nightsCount <= 14) {
                studioPrice -= studioPrice * 0.05;
            } else if (nightsCount > 14) {
                studioPrice -= studioPrice * 0.30;
                apertmentPrice -= apertmentPrice * 0.10;
            }
            break;
        case "June":
        case "September":
            apertmentPrice = 68.70;
            studioPrice = 75.20;
            if (nightsCount > 14) {
                studioPrice -= studioPrice * 0.20;
                apertmentPrice -= apertmentPrice * 0.10;
            }
            break;
        case "July":
        case "August":
            apertmentPrice = 77;
            studioPrice = 76;
            if (nightsCount > 14) {
                apertmentPrice -= apertmentPrice * 0.10;
            }
            break;
    }

    console.log(`Apartment: ${(nightsCount * apertmentPrice).toFixed(2)} lv.`);
    console.log(`Studio: ${(nightsCount * studioPrice).toFixed(2)} lv.`);
}

hotelRoom(["May","15"]);
hotelRoom(["June","14"]);
hotelRoom(["August","20"]);