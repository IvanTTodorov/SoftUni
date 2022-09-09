function solve (month, year) {
return new Date(year, month, 0).getDate(); 
}

console.log(solve(12, 2000));