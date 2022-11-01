function focused() {
   Array.from(document.querySelectorAll('input')) 
   .forEach(i => { 
    i.addEventListener('focus', onfocus) 
    i.addEventListener('blur', onBlur)
   })


        function onfocus(ev) { 
            ev.target.parentElement.className = 'focused'
        } 

        function onBlur(ev) { 
            ev.target.parentElement.className = 'blur';
        }
    }
