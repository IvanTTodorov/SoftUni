const expect = require('chai').expect;
const evenOrOdd = require('./02.EvenorOdd'); 

describe('Even or odd checker', () => {
    it('if the input is int, throw undefined', () => {
        expect(evenOrOdd(5)).to.equal('undefined');
    });
    it('if the input is object, throw undefined', () => {
        expect(evenOrOdd({})).to.equal('undefined');
    })
    it('check if the input has even length', () => {
        expect(evenOrOdd('text')).to.equal('even'); 
    });
    it('check if the input has odd length', () => {
        expect(evenOrOdd('Maria')).to.equal('odd'); 
    });
});