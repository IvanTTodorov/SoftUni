const expect = require('chai').expect;
const mathEnforcer = require('./04.MathEnforcer'); 

describe('Math enforcer checker', () => {

    describe('Add five function', () => {
        it('should return undefined if param is not a number', () => {
            expect(mathEnforcer.addFive('Maia')).to.equal(undefined); 
        });
        it('should return correct answer with adding five method', () => {
            expect(mathEnforcer.addFive(5)).to.equal(10); 
            expect(mathEnforcer.addFive(-12)).to.equal(-7);
            expect(mathEnforcer.addFive(0.7)).to.be.closeTo(5.7, 0.01);
        });
    });
    describe('Subtract ten function', () => {
        it('should return undefined if param is not a number', () => {
            expect(mathEnforcer.subtractTen('Maia')).to.equal(undefined); 
        });
        it('should return correct answer with subtracting ten method', () => {
            expect(mathEnforcer.subtractTen(5)).to.equal(-5); 
            expect(mathEnforcer.subtractTen(-12)).to.equal(-22);
            expect(mathEnforcer.subtractTen(20.7)).to.be.closeTo(10.7, 0.01);
        });
    });

        describe('Sum function', () => {
            it('should return undefined if first param is not a number', () => {
                expect(mathEnforcer.sum('Maia', 0)).to.equal(undefined); 
            });
            it('should return undefined if second param is not a number', () => {
                expect(mathEnforcer.sum(9, 'z')).to.equal(undefined); 
            });
            it('should return correct sum if the two of the params are correct', () => {
                expect(mathEnforcer.sum(9, 1)).to.equal(10); 
                expect(mathEnforcer.sum(9.2, 1.1)).to.be.closeTo(10.3, 0.01); 
            });
        });  
});