function deleteByEmail() {
    let arrEmails = document.querySelectorAll('tr td:nth-of-type(2)')
    let emailElement = document.querySelector('input[name ="email"]') 
    let result = document.getElementById('result'); 

        let emailElements = Array.from(arrEmails); 
        let currentElement = emailElements.find(x=> x.textContent == emailElement.value); 
         
        if(currentElement) { 
            currentElement.parentNode.remove(); 
            result.textContent = 'Deleted.'
        }  
        else { 
            result.textContent = 'Not found.'
        }
} 
