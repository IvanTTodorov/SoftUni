function solve() {
 let text = document.getElementById('input'); 
 let arr = text.value.split('.').filter(s=> s!== '');   
 let result = document.getElementById('output');
 console.log(arr); 

 while(arr.length > 0) { 
let output = arr.splice(0,3).join('. ') + '.'; 
let p = document.createElement('p'); 
p.textContent = output; 
result.appendChild(p);
 }
}