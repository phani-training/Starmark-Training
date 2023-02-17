describe('First Examples of Tests', () => {
    it('should be successfull', () => {
        expect("TestExample").toBe("TestExample");
    });

    it('should add 2 numbers', () => {
        expect(3 + 4).toBe(7);
    });
    
    it('should be true', () => {
        expect(true).toBeTruthy();
    });
});