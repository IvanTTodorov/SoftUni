function addItem() {
    let list = document.getElementById('items')  
    let newText = document.getElementById('newItemText')
    let element = document.createElement('li'); 
    element.textContent = newText.value; 
     
    list.appendChild(element);
}