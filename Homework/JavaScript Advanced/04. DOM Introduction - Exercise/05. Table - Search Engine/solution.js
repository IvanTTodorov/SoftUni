function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick); 
   let text = document.getElementById('searchField')
   let table = document.querySelectorAll('tbody tr');

   function onClick() { 
      for (const row of table) {
         row.classList.remove('select');  
         if(text.value !== '' && row.innerHTML.includes(text.value)) { 
            row.className = 'select'
         }
      }
   }
}
