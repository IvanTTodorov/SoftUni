function solve(arr) {

    let obj = {}; 

    for (let i = 0; i < arr.length; i++) {
        let text = arr[i]; 
        let input = text.split(' | '); 
        let town = input[0]; 
        let productName = input[1]; 
        let price = Number(input[2]);
        
        if(!obj.hasOwnProperty(productName)) {
            obj[productName] = {town, price}; 
        } else {
            if(price < obj[productName].price) {
                obj[productName] = {town, price}; 
            }
        }
    }
    let products = Object.keys(obj); 

    for (let i = 0; i < products.length; i++) {
        let product = products[i]; 
        console.log(`${product} -> ${obj[product].price} (${obj[product].town})`);
    }



}










solve(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
); 