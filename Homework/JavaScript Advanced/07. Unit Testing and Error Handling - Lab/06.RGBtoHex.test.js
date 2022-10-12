const expect = require('chai').expect; 
const rgbToHexColor = require('./06.RGBtoHex'); 

describe('Rgb To Hex Color Checker', () => {
    it('Should return unDef because of not integer intput', () => {
        expect(rgbToHexColor('red', 5, 32)).to.be.undefined
    });

    it('Should return unDef because of negative number', () => {
        expect(rgbToHexColor(-4, 60, 70)).to.be.undefined
    });

    it('Should return unDef because of big number', () => {
        expect(rgbToHexColor(256, 5, 2)).to.be.undefined
    });

    it('Should return red colour', () => {
        expect(rgbToHexColor(255, 0, 0)).to.equal('#FF0000');
    }) 
    it('Returns undefined for missing parameters', () => {
        expect(rgbToHexColor(255)).to.be.undefined;
    });


});


