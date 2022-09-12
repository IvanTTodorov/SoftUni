function solve(input, n){
for (let i = 0; i < n; i++) {
    let lastElement = input.pop(); 
    input.unshift(lastElement); 
}
console.log(input.join(' '));
}
solve(['1', 
'2', 
'3', 
'4'], 
2); 