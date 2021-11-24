//import
//for using import below method we can not use default in file
//if we use default then import should be
//import * as strings from './StringValidator';
import { StringValidator } from "./StringValidator";
export const numberRegexp = /^[0-9]+$/;
export default class ZipCodeValidator implements StringValidator {
  isAcceptable(s: string) {
    return s.length === 5 && numberRegexp.test(s);
  }
}
// export { ZipCodeValidator };
// export { ZipCodeValidator as mainValidator };
