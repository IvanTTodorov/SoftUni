function search() {
   let towns = Array.from(document.querySelectorAll('#towns li'));
   let searchText = document.getElementById('searchText').value; 
   let result = document.getElementById('result');
   let count = 0;
   
   for (let town of towns) {
      if (town.textContent.includes(searchText) && searchText !== '') {  
         town.style.fontWeight = 'bold'; 
         town.style.textDecoration = 'underline';
      count++;
    }     
    else { 
      town.style.fontWeight = 'normal'; 
      town.style.textDecoration = 'none';
    }
   }   

   result.textContent = `${count} matches found`
}
