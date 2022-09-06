function solve (first, second, third) {
    let firstLength = first.length; 
    let secondLength = second.length; 
    let thirdLength = third.length; 

    let sum = firstLength + secondLength + thirdLength;
    let average = Math.floor(sum / 3); 

    console.log(sum);
    console.log(average); 
}
solve('chocolate', 'ice cream', 'cake');