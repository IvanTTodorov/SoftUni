window.addEventListener('load', solve);

function solve() {
     
    let button = document.getElementById('add').addEventListener('click', addButtonHandler); 
    let model = document.getElementById('model');  
    let year = document.getElementById('year');  
    let description = document.getElementById('description');  
    let price = document.getElementById('price');   
    let furnitureList = document.getElementById('furniture-list'); 

    function addButtonHandler(e)  {  
        e.preventDefault();
        console.log('add button clicked'); 
    
    
  
    let priceValue = Number(price.value); 
    let yearValue = Number(year.value); 

    if(!model.value || !description.value) { 
        return;
    } 
     if(yearValue <= 0 || priceValue <= 0) { 
        return;
    }  
     
    let rowElement = document.createElement('tr'); 
    let modelCellElement = document.createElement('td');  
    let priceCellElement = document.createElement('td'); 
    let actionCellElement = document.createElement('td'); 
    let infoButtonElement = document.createElement('button'); 
    let buyButtonElement = document.createElement('button'); 
    let contentsRowElement = document.createElement('tr'); 
    let yearContentElement = document.createElement('td'); 
    let descriptionContentElement = document.createElement('td'); 

     modelCellElement.textContent = model.value;  
    priceCellElement.textContent  = priceValue.toFixed(2);
    infoButtonElement.textContent = 'More Info'; 
    buyButtonElement.textContent = 'Buy it';   
    buyButtonElement.classList.add('buyBtn');  
    infoButtonElement.classList.add('moreBtn');
 
    // ShowMore Function *
    infoButtonElement.addEventListener('click', showMoreInfo);
    function showMoreInfo(e) {

        if(infoButtonElement.textContent === 'More Info'){
        infoButtonElement.textContent = 'Less Info'; 
         contentsRowElement.style.display = 'contents'; 

        } else {
            infoButtonElement.textContent = 'More Info'
            contentsRowElement.style.display = 'none'; 
        }
        yearContentElement.textContent = `Year: ${yearValue}`;
        descriptionContentElement.setAttribute('colspan', 3); 
        descriptionContentElement.textContent = `Description: ${description.value}`; 
    
        contentsRowElement.classList.add('hide'); 
       
    
        contentsRowElement.appendChild(yearContentElement); 
        contentsRowElement.appendChild(descriptionContentElement);   
    } 

    // BuyIt function 
     buyButtonElement.addEventListener('click', (e) => {  
        
        rowElement.remove();  
        contentsRowElement.remove();

        let totalPriceElement = document.querySelector('.total-price'); 
        let totalPrice = Number(totalPriceElement.textContent) + priceValue; 
        totalPriceElement.textContent = totalPrice.toFixed(2); 

     })


    // Adding buttons and cells in rows;
    actionCellElement.appendChild(infoButtonElement); 
    actionCellElement.appendChild(buyButtonElement); 

    rowElement.classList.add('info'); 
    rowElement.appendChild(modelCellElement); 
    rowElement.appendChild(priceCellElement); 
    rowElement.appendChild(actionCellElement);


    // Adding rows in FurnitureList.
    furnitureList.appendChild(rowElement);
    furnitureList.appendChild(contentsRowElement); 

}

}
