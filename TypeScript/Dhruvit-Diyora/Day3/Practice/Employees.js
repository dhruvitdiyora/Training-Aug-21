//creating namespace
var StringUtility;
(function (StringUtility) {
    function ToCapital(str) {
        return str.toUpperCase();
    }
    StringUtility.ToCapital = ToCapital;
    function SubString(str, from, length = 0) {
        return str.substr(from, length);
    }
    StringUtility.SubString = SubString;
})(StringUtility || (StringUtility = {}));
//tsc --outFile C:\MyTypeScriptNameSpaces\StringUtility.js C:\MyTypeScriptNameSpaces\StringUtility.ts
