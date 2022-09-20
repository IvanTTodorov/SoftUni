function solve(arr) { 
     
    let obj = []; 

    class Game {
        constructor(name, level, items) {
          this.name = name; 
          this.level = level; 
          this.items = items;  
        }
    }

    for (let i = 0; i < arr.length; i++) { 
        let info = arr[i].split(' / '); 
        let name = info[0]; 
        let level = Number(info[1]);  
        let currentItems = [];
        
        let allItems = info[2] ? info[2].split(', ') : []; 
        
        

        for (let i = 0; i < allItems.length; i++) {   
            let item = allItems[i]; 
            currentItems.push(item);
        } 

        let game = new Game(name, level, currentItems); 
        obj.push(game); 

        
}  
return JSON.stringify(obj); 

} 
 
solve(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara'])