function solve(input, text) {
    if(text === 'asc') {
        return input.sort((a,b) => a - b); 
    } else {
        return input.sort((a,b) => b - a); 
    }

}
console.log(solve([14, 7, 17, 6, 8], 'asc'));