const expect = require('chai').expect;
const charLookUp = require('./03.CharLookup'); 

describe('Char checker', () => {
    it('if the first param is not a string, return undefined', () => {
        expect(charLookUp(5, 5)).to.equal(undefined); 
    });
    it('if the second param is not a int, return undefined', () => {
        expect(charLookUp('min', 'max')).to.equal(undefined); 
    });
    it('if the word length is smaller than the index, return error', () => {
        expect(charLookUp('min', 10)).to.equal('Incorrect index'); 
    });
    it('if the index is negative number, return error', () => {
        expect(charLookUp('min', -3)).to.equal('Incorrect index'); 
    });
    it('return correct answer if the both params are correct', () => {
        expect(charLookUp('Maria', 0)).to.equal('M'); 
    });

});