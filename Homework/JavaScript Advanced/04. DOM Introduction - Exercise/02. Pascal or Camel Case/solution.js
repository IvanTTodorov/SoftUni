function solve() {
 let text = document.getElementById('text').value; 
 let convention = document.getElementById('naming-convention') 
 let conventionText = convention.value;
 let result = '';  

 

 if (conventionText === 'Camel Case') {  
 for  (let i = 0; i < text.length; i++ ) {   
   
  if(text[i] === ' ') { 
    result += (text[i+1].toUpperCase()); 
    i++;
  }  
  else { 
    result += text[i].toLowerCase();
  }
 } 


 } 
 else if (conventionText === 'Pascal Case') {  
  for  (let i = 0; i < text.length; i++ ) {   
  if(text[i] === ' ') { 
    result += (text[i+1].toUpperCase()); 
    i++;
  }   
  else if (i === 0) { 
    result += (text[i].toUpperCase()); 
  }
  else { 
    result += text[i].toLowerCase();
  }
 }   
}

 else { 
  result = 'Error!'
 } 

 let resultElement = document.getElementById('result'); 
resultElement.textContent = result; 
}