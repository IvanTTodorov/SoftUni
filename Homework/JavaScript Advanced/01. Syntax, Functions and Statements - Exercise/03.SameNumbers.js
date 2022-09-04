function demo(a) {
    let number = a.toString(); 
    let isSame = true; 
    let sum = 0;

    let digitToCompare = number[0]; 

    for (let i = 0; i < number.length; i++) {
       sum += Number(number[i]); 
       
       if(number[i] !== digitToCompare) {
        isSame = false;
       }
    }
    console.log(isSame);
    console.log(sum);
}
demo(2222222); 