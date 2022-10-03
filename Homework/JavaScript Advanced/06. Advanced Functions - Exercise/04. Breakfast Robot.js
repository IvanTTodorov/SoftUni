function solution() {
    let storage = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    const commands = {
        restock,
        prepare,
        report

    };

    const recipies = {
        apple: {
            carbohydrate: 1, 
            flavour: 2
        }, 
        lemonade: {
            carbohydrate: 10, 
            flavour: 20
        },
        burger: {
            carbohydrate: 5, 
            fat: 7, 
            flavour: 3
        },
        eggs: {
            protein: 5, 
            fat: 1, 
            flavour: 1
        },
        turkey: {
            protein: 10, 
            carbohydrate: 10, 
            fat: 10, 
            flavour: 10
        }

    };
    return manager;

    function manager(line) {
        const [command, stock, quantity] = line.split(' ');
        return commands[command](stock, quantity);
    }

    function restock(type, quantity) {
        storage[type] += Number(quantity);
        return 'Success';
    }

    function prepare(type, quantity) {
        let recipe = Object.entries(recipies[type]); 
        quantity = Number(quantity); 

        recipe.forEach(x => x[1]  *= quantity);
       
        for (const [ingredient, required] of recipe) {
            if(storage[ingredient] < required) {
                return `Error: not enough ${ingredient} in stock`
            }  
        }

        recipe.forEach(([ingredient, required]) => storage[ingredient] -= required); 
        return 'Success'; 
    }

    function report() {
        return `protein=${storage.protein} carbohydrate=${storage.carbohydrate} fat=${storage.fat} flavour=${storage.flavour}`;
    }
}

let manager = solution();

console.log(manager("restock flavour 50")); // Success 
console.log(manager("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log(manager("restock carbohydrate 10"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare apple 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare burger 1"));
console.log(manager("report"));




