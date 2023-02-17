const app = require("../src/mathModule");

describe('Unit Testing for MathComponent Module', () => {
    it('should add 2 numbers', () => {
        //arrange
        const input1 = 123;
        const input2 = 234;
        const expected = 357;
        //act
        const actual = app.addFunc(input1, input2);
        //assert
        expect(actual).toBe(expected);
    });

    it("should have value", ()=>{
        //arrange
        var data = [12,13,14,15];
        expect(data).toContain(15);
    })
});