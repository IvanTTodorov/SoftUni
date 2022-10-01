function solve (...params) {
let obj = {}; 


for (const input of params) {
    console.log(`${typeof(input)}: ${input}`)
    if(!obj[typeof(input)]) {
        obj[typeof(input)] = 1; 
    } else {
        obj[typeof(input)] += 1; 
    }
}
    let result = Object.entries(obj).sort((a,b) => b[1] - a[1]); 

    for (const [key, value] of result) {
        if(value > 0 ) {
        console.log(`${key} = ${value}`)
        }
   
    }

}
solve('cat', 42, 56, function () { console.log('Hello world!'); })