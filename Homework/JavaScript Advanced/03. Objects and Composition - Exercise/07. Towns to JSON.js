function solve(arr) {

let result = []; 

class Town {
    constructor(name, latitude, longitude) {
        this.Town = name; 
        this.Latitude = Number(latitude);
        this.Longitude = Number(longitude); 
    }
}

for(let i = 1; i < arr.length; i++) {
    let line = arr[i].split('|').map(t => t.trim()).filter(x => x.length != 0); 
    let townName = line[0]; 
    let latitude = Number(line[1]).toFixed(2); 
    let longitude = Number(line[2]).toFixed(2);  
    let town = new Town(townName,latitude,longitude); 
    result.push(town);
} 
 
return JSON.stringify(result);

}

solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
)