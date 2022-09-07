function solve (first, second, third) { 
    if(first > second && first > third) {
        console.log('The largest number is' + ' ' +  first + '.');
    }
    else if(second > third && second > first){
        console.log('The largest number is' + ' ' +  second + '.');
    } else if (third > second && third > first){
        console.log('The largest number is' + ' ' +  third + '.');
    }
}
solve(5, -3, 16);