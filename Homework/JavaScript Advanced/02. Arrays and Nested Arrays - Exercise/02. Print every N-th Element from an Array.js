function solve(input, n) {
    let arr = [];

    for(let i = 0; i < input.length; i+=n) {
        arr.push(input[i]); 
    }
    return arr;
}
solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2); 