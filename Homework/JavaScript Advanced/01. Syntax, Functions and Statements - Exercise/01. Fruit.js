function demo(fruit, weight, price) {
    let fruitType = fruit; 
    let fruitWeight = weight; 
    let fruitPrice = price;

    let fruitPerKilo = fruitWeight / 1000; 
    let totalPrice = fruitPerKilo * fruitPrice; 

    console.log(`I need $${totalPrice.toFixed(2)} to buy ${fruitPerKilo.toFixed(2)} kilograms ${fruitType}.`);
    }
    demo('orange', 2500, 1.80);