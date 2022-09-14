function solve (input) {  
  let matrix = [];
  let leftDiagonal = 0; 
  let rightDiagonal = 0; 
  while(input.length > 0) { 
    matrix.push(input.shift().split(' ').map(Number));
  } 

  for(let i = 0; i < matrix.length; i++) {   
        leftDiagonal += matrix[i][i]; 
        rightDiagonal += matrix[i][matrix.length - 1 - i]
        }  


       if(leftDiagonal === rightDiagonal) { 
        for(let i = 0; i < matrix.length; i++) {  
          for(let j = 0; j < matrix[i].length; j++) {    
            if ((j !== i) && (j !== matrix.length - 1 - i)) {  
              matrix[i][j] = leftDiagonal;
            } 
          }  
        } 
      } 
 
      for(let i = 0; i < matrix.length; i++) {  
        console.log(matrix[i].join(' '));
       }
} 

 solve(['5 3 12 3 1',
 '11 4 23 2 5',
 '101 12 3 21 10',
 '1 4 5 2 2',
 '5 22 33 11 1']
 )  1

 solve(['1 1 1',
 '1 1 1',
 '1 1 0']
 )