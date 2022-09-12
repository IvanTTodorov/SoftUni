function solve(input) {
let array = []; 
let theBiggest = input[0];
array.push(input[0]);

    for(let i = 0; i < input.length; i++) {
     if(theBiggest < input[i+1]) {
        array.push(input[i+1]); 
        theBiggest = input[i+1]; 
     }   
}
return array;
}
solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]); 