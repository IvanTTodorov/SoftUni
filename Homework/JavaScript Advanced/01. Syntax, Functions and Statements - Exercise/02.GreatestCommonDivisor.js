function demo(a, b) {
    let number1 = Number(a); 
    let number2 = Number(b); 

    while (number1 !== number2) {
        if(number1 > number2) {
            number1 -= number2;
        } else {
            number2 -= number1; 
        }
    }
    console.log(number2); 
}
demo(30, 10); 