function toggle() {
    let command = document.querySelector('.button');  
    let text = document.querySelector('#extra');
      
    if(command.textContent === 'More') { 
        command.textContent = 'Less';  
        text.style.display = 'block'

    }  
    else {  
        command.textContent = 'More'; 
        text.style.display = 'none';
    } 

  
}