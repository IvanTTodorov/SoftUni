function validate() { 
    let email = document.getElementById('email');

    let pattern = /[a-z]*@[a-z]*.[a-z]*/g;  
   
 
    email.addEventListener('change',checkEmail);

       function checkEmail(e) {
           if(pattern.test(e.target.value)){
               e.target.removeAttribute('class');
               return;
           }

           e.target.className = 'error';
       }
}