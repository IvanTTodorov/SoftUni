function solution(input) {

    let obj = new Object; 

    for (const newText of input) {
        let arrCurrentText = newText.split(' '); 
        let command = arrCurrentText[0]; 
        let name = arrCurrentText[1]; 

        if(command === 'create' && arrCurrentText.length == 2) {
            obj.name = name; 
        } else if(command === 'create' && arrCurrentText.length == 4) {
            
        }
        
    }
    
    

}
solution(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']
);