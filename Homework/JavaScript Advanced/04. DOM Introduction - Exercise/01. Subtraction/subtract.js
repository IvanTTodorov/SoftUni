function subtract() {  
    let firstN = document.getElementById('firstNumber') 
    let secondN = document.getElementById('secondNumber') 
    let result = document.getElementById('result') 
    result.textContent = firstN.value - secondN.value;
    console.log(result);
}