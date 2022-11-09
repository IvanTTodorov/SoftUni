function addItem() {
    let itemText = document.getElementById('newItemText').value;
    let itemValue = document.getElementById('newItemValue').value; 

    
    let option = document.createElement('option'); 
    option.text = itemText;
    option.value = itemValue; 

    if(itemText !== '' && itemValue !== '') {
    let menu = document.getElementById('menu');
    menu.appendChild(option);
    }
    itemText = document.getElementById('newItemText').value = '';
    itemValue = document.getElementById('newItemValue').value = '';
}

