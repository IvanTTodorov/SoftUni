function colorize() {
    let elementsForColors = document.querySelectorAll('tr:nth-of-type(2n) td'); 
    elementsForColors.forEach(x=> { 
        x.style.backgroundColor = 'Teal'
    });
}