function solve(input) {

    let first = input.shift(); 
    let last = input.pop();
    
    const result = Number(first) + Number(last); 

    console.log(result);
}
solve(['20', '30', '40']);