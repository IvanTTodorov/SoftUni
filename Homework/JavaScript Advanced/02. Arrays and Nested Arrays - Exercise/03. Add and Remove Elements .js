function solve(input) {
let arr = [];

for(let i = 0; i < input.length + 1; i++ ) {
    if(input[i] === 'add') {
        arr.push(i + 1);
    } 
    else if (input[i] === 'remove') { 
        arr.pop();
    }
} 
if(arr.length == 0) {
    console.log('Empty'); 
}

else{
    console.log(arr.join('\n')); 
}
}

solve(['add', 
'add', 
'add', 
'add']); 