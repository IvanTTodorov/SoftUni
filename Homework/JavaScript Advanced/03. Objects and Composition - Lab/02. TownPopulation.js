function population(input) {

    const towns = {}; 
for(let data of input) {
    const tokens = data.split(' <-> ');
    const name = tokens[0];   
    const population = Number(tokens[1]);
    
    if(towns[name] == undefined) {
        towns[name] = population; 
     } else {
        towns[name] += population; 
     }
}
for (const name in towns) {
    console.log(`${name} : ${towns[name]}`);
}

}
population(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);