const expect = require('chai').expect; 
const isSymetric = require('./05.CheckforSymmetry'); 

describe('Symmetry Checker', () => {
    it('returns true for symmetric array', () => {
        expect(isSymmetric([1, 2, 2, 1])).to.be.true;
    });

    it('returns false for asymmetric array', () => {
        expect(isSymmetric([1, 2, 3])).to.be.false;
    });

    it('returns false for non-array', () => {
        expect(isSymmetric(5)).to.be.false;
    });

    it('returns false for type-different symmetric array', () => {
        expect(isSymmetric([1, 2, '1'])).to.be.false;
    });

    //Test overloading
    it('returns true for symmetric array with odd number of elements', () => {
        expect(isSymmetric([1, 2, 1])).to.be.true;
    });

    it('returns true for symmetric array with strings', () => {
        expect(isSymmetric(['a', 'b', 'b', 'a'])).to.be.true;
    });

    it('returns false for asymmetric array with strings', () => {
        expect(isSymmetric(['a', 'b', 'c'])).to.be.false;
    });

    it('returns false for string parameter', () => {
        expect(isSymmetric('abba')).to.be.false;
    });
});

