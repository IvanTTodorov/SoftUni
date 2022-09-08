function solve (first, second, operation) { 
    let result; 
    switch(operation) {
    case '+': result = first + second; break;
    case '-': result = first - second; break;
    case '*': result = first * second; break;
    case '/': result = first / second; break;
    case '%': result = first % second; break;
    case '**': result = first ** second; break;
    }
    console.log(result);
}

solve(4, 5, '-');