const { expect } = require('chai');
const sum  = require('./04.SumOfNumbers');
describe('Sum', () => {
    it('passing test', () => {
        expect(sum([5, 3])).to.equal(8);
    });
});