function solve(input) {
    let arr = [];
    for(let i = 0; i < input.length; i++) {
        input.sort((a, b) => a.localeCompare(b)); 
        arr.push(`${i + 1}.${input[i]}`);
    }
console.log(arr.join('\n')); 
}
solve(["John", "Bob", "Christina", "Ema"]); 