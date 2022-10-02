function extract(content) {
let contentElement = document.getElementById('content'); 
let text = contentElement.textContent; 
let pattern = /(\([A-Za-z\s]+\))/g; 
let matches = contentElement.textContent.matchAll(pattern); 
 
let result = [];
for (const match of matches) {
    result.push(match);
} 

return result.join('; ');
}