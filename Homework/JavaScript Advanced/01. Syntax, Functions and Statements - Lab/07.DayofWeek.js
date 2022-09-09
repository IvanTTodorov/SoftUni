function solve (dayOfWeek) {
    let day = 0; 
    if(dayOfWeek == 'Monday') {
    day = 1; 
    } else if(dayOfWeek =='Tuesday') {
        day = 2;
    } else if(dayOfWeek == 'Wednesday') {
        day = 3; 
    } else if(dayOfWeek == 'Thursday') {
        day = 4; 
    } else if (dayOfWeek == 'Friday') {
        day = 5;
    } else if(dayOfWeek == 'Saturday') {
        day = 6;
    } else if(dayOfWeek == 'Sunday') {
        day = 7; 
    } else {
        return 'error';
    }
    return day; 
}

console.log(solve('Monday'));
console.log(solve('Error'));