function demo(num, f1, f2, f3, f4, f5) {
    let number = Number(num);
    let arrCommands = [f1, f2, f3, f4, f5];
        let chop = function(){
        return number/2;
    };
    let dice = function(){
        return Math.sqrt(number);
    }; 
    let spice = function(){
        return number+1;
    };
    let bake = function(){
        return number*3;
    };
    let fillet = function(){
        return number * 0.8; 
    }; 

    for(let i = 0; i <arrCommands.length; i++) { 
        let currentCommand = arrCommands[i]; 

        switch(currentCommand) { 
            case 'chop' : 
                number = chop(number); 
                break; 
            case 'dice' :  
                number = dice(number);  
                break;  
            case 'spice' :  
                number = spice(number);  
                break;  
                case 'bake' :  
                number = bake(number);  
                break;  
                case 'fillet' :  
                number = fillet(number);   
                number = number.toFixed(1);
                break; 
        } 
        console.log(number);
    } 
 }
 demo('9', 'dice', 'spice', 'chop', 'bake', 'fillet')
