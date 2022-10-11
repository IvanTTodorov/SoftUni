const expect = require('chai').expect; 
const sum = require('./04.SumofNumbers');


describe('Sum of numbers', () => {
    it('Should return the sum of numbers of the array', () => {
        let numbers = [1, 2, 3, 4, 5]; 
        let expectedSum = 15; 
        let actualSum = sum(numbers); 

        expect(actualSum).to.equal(expectedSum); 
    }); 
    it('Should return zero if the numbers are zeros', () => {
        let numbers = [0, 0, 0, 0]; 
        let expectedSum = 0; 
        let actualSum = sum(numbers); 

        expect(actualSum).to.equal(expectedSum); 
    });
   
        it('it sums correctly with one number', () => {
            expect(sum([1])).to.equal(1);
        });
});


