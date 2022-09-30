function extractText() {
    let ulElements = document.getElementById('items'); 

    let textareaElement = document.getElementById('result');  
    textareaElement.textContent = ulElements.textContent
    
}