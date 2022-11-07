function lockedProfile() {
    
    Array.from(document.querySelectorAll('.profile button')) 
    .forEach(button => button.addEventListener('click', OnClick)) 



    function OnClick(ev) { 
        let profile = ev.target.parentElement;
        let isActive = profile.querySelector('input[value = "unlock"]').checked;   
     
        if(isActive) { 
            let hiddentFieldsInformation = Array.from(profile.querySelectorAll('div')) 
            .find(p => p.id.includes('HiddenFields'));  
        if(ev.target.textContent === 'Show more') {
            ev.target.textContent = 'Hide it'
            hiddentFieldsInformation.style.display = 'block' 
        } 
        else {  
            ev.target.textContent = 'Show more'
           hiddentFieldsInformation.style.display = 'none'
        }
        }
    }
}