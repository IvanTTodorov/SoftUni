function solution(array, start, end) {

    
    let startIndex = Math.max(start, 0); 
    let endIndex = Math.min(end, array.length - 1); 


    if(!Array.isArray(array)) {
        return  NaN; 
    }
    let subNumbers = array.slice(startIndex, endIndex + 1); 

    let sum = subNumbers.reduce((a, x) => a + Number(x), 0); 
    return sum;

   }

solution([10, 20, 30, 40, 50, 60], 3, 300);
solution([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1); 