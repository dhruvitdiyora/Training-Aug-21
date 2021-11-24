import validator from "./ZipCodeValidator";
let myValidator = new validator();
myValidator.isAcceptable("test");

//default exports can also be just values:

//export default "123";
//tsc --outFile sample.js Test.ts
//tsc --outFile sample.js Validation.ts LettersOnlyValidator.ts ZipCodeValidator.ts Test.ts
