function dayOfWeek(num) {
    let dayOfWeekArr = [
        'Monday',
        'Tuesday',
        'Wednesday',
        'Thursday',
        'Friday',
        'Saturday',
        'Sunday'
    ];

    if(num >= 1 && num <=7){
        console.log(dayOfWeekArr[num - 1]);
    }else {
        console.log('Invalid day!');
    }
}

dayOfWeek(1);
dayOfWeek(2);
dayOfWeek(3);
dayOfWeek(4);
dayOfWeek(5);
dayOfWeek(6);
dayOfWeek(7);
dayOfWeek(0);
dayOfWeek(9);
