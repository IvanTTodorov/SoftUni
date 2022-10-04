function calculator() {
    let field1 = null;
    let field2 = null;
    let result = null;

    return {
        init, 
        add, 
        subtract
    }

    function init(selector1, selector2, resultSelector) {
        field1 = document.querySelector(selector1); 
        field2 = document.querySelector(selector2); 
        result = document.querySelector(resultSelector);  

    }
    function add() {
        result.value = Number(field1.value) + Number(field2.value); 
    }
    function subtract() {
        result.value = Number(field1.value) - Number(field2.value); 
    }
}
const calculate = calculator (); 
calculate.init ('#num1', '#num2', '#result'); 





