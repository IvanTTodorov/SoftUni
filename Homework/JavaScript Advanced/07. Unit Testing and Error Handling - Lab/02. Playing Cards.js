function solve(face, suit) {

    const cardFaces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J','Q', 'K', 'A']; 
    const cardSuits = {
        S: '\u2660', 
        H: '\u2665', 
        D: '\u2666',
        C: '\u2663'
    };

    if(!cardFaces.includes(face) && !cardSuits[this.suit] || face !== face.toUpperCase() || suit !== suit.toUpperCase()) {
        throw new Error('Error');
        
    }
    let card = {
        face, 
        suit, 
        toString() {
            console.log(this.face + cardSuits[this.suit]);
        }
    };

   return card; 
};
let cardItem = solve('10', 'H');
cardItem.toString(); 