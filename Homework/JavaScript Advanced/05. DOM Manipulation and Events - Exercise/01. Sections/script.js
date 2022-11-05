function create(words) {
   let elements = words; 
   let parentElement = document.getElementById('content')

   for( let i = 0; i < elements.length; i++) {
      let div = document.createElement('div'); 
      let p = document.createElement('p'); 
      let text  = document.createTextNode(elements[i]); 


      p.appendChild(text); 
      p.style.display = 'none'; 
      div.appendChild(p); 
      div.addEventListener('click', function(e) {
        e.target.children[0].style.display = 'block';
      });
      parentElement.appendChild(div); 
   }
}