function solve(matrix) {

    let sum1 = 0; 
    let sum2 = 0;  
    let result = ' '
    for(let row = 0; row < matrix.length; row++) {
            sum1 += matrix[row][row];
        }    
    result += sum1; 
    result += ' ';

        let count = 0;
    for(let row = matrix.length - 1; row >= 0; row--) { 
        let index = ' ';   
        
    index = count;
    count ++;
    sum2 += matrix[row][index];
    } 
    result += sum2; 
    
    console.log(result);
    }



solve([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);  

solve([[20, 40],
    [10, 60]]
   )
