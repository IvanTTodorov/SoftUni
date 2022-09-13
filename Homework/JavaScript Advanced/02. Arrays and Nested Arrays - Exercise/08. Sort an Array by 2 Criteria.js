function solve(input) {

input.sort((a,b) => 
    a.length - b.length || a.localeCompare(b)
);

input.forEach((key) => {
console.log(key); 
});
}
solve(['alpha', 
'beta', 
'gamma']);  