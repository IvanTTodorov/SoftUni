function solve(n, k) {
    let result = []; 
    
    for (let i = 0; i < n; i++) {
        let newNumber = 0; 
        if(i == 0 || i == 1) {
            result.push(1); 
          
        }
        else if(i== 2) {
            result.push(2);
           
        }
        else {
           for( let j = 1; j <= k; j++) {
            
            newNumber += result[i - j];
            
           }
           result.push(newNumber); 
            
        }
    }
    console.log(result);
}
solve(8, 2);  
solve(6, 3)