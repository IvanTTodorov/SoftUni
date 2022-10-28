function addItem() {
    let itemsList = document.getElementById('items'); 
    let currentItem = document.createElement('li'); 
    let newText = document.getElementById('newItemText'); 
      
    currentItem.textContent = newText.value; 

    let deleteElement = document.createElement('a'); 
    deleteElement.href = '#'; 
    deleteElement.textContent = '[Delete]';
    
    deleteElement.addEventListener('click', function() {
        itemsList.removeChild(currentItem); 
    });

    currentItem.appendChild(deleteElement); 

    itemsList.appendChild(currentItem); 
}