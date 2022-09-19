function solve(input) { 
    let arr = {};
    for (let i = 0; i < input.length; i+=2 ) {  

            let name = input[i];
            let calories =Number(input[i+1]) 
            arr[name] = calories;
        }

       console.log(arr) 
    }  





solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
 
solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);