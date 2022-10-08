function solution(input) {


   let output = []; 

   for (const oneText of input) {
      let arrCurrentText = oneText.split(' '); 
      let command = arrCurrentText[0]; 
      let text = arrCurrentText[1]; 

      if(command === 'add') {
        output.push(text); 
      } else if(command === 'remove') {
        output = output.filter(i => i !== text);
      } else if( command === 'print') {
        console.log(output.join(',')); 
      }
    }
   

}

solution(['add hello', 'add again', 'remove hello', 'add again', 'print']);
solution(['add pesho', 'add george', 'add peter', 'remove peter','print']); 