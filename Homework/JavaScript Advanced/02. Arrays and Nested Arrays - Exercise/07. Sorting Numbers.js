function solve(input){

    let newArr = []; 

    input = input.sort((a,b) => a-b);
    
    while (input.length != 0) {
        newArr.push(input.shift()); 
        newArr.push(input.pop()); 
    }
return newArr;
}
solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]); 