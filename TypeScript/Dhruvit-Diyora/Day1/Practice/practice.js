var num1 = 7;
console.log(num1);
var str1 = "Hello world";
console.log(str1);
var isTrue = true;
console.log(isTrue);
//functions
function hello(person) {
    console.log("hello ".concat(person));
}
hello("d");
//Array
var nums = [1, 2, 3, 4, 5, 6];
var nusm2 = [9, 8, 7, 6, 5, 4, 3];
var names = ["a", "b", "c", "d", "e"];
//any type
var obj = { x: 0 };
obj.foo();
obj();
obj.bar = 100;
obj = "hello";
var n = obj;
//Type Annotations on Variables
var myName = "Dhruvit";
var myName2 = "diyora";
//anonymous fun
names.forEach(function (s) {
    console.log(s.toUpperCase());
});
//object type
function ShowName(fname, lname) {
    console.log("first name " + fname + "last name " + lname);
}
ShowName("dhruvit", "diyora");
function printCoord(pt) {
    console.log("The coordinate's x value is " + pt.x);
    console.log("The coordinate's y value is " + pt.y);
}
printCoord({ x: 3, y: 7 });
//Optional Properties
function printName(obj) {
    console.log("first name " + obj.first + "last name " + obj.last);
}
// Both OK
printName({ first: "dhruvit" });
printName({ first: "dhruvit", last: "diyora" });
//Union Types
function printId(id) {
    console.log("Your ID is: " + id);
}
// OK
printId(101);
// OK
printId("202");
// Error
//printId({ myID: 22342 });
function printIds(id) {
    if (typeof id === "string") {
        // In this branch, id is of type 'string'
        console.log(id.toUpperCase());
    }
    else {
        // Here, id is of type 'number'
        console.log(id);
    }
}
printIds(101);
// OK
printIds("dhruvit");
//number
var number1 = 3.14285742857;
console.log(number1.toExponential(6));
console.log(number1.toFixed(6));
console.log(number1.valueOf());
console.log(number1.toString());
console.log(number1.toLocaleString());
//string
var str = "valar morghulis!";
console.log(str.charAt(5));
console.log(str.concat("dddd"));
console.log(str.indexOf("m"));
console.log(str.replace("morghulis", "dohaireas"));
console.log(str.split(" "));
console.log(str.toUpperCase());
console.log(str.toLowerCase());
console.log(str.slice(3, 5));
console.log(str.substr(3, 3));
//multi Type Array
var values = ['dhruvit', 1, 'diyora', 3, 2, 6, 'surat', 'dhruvitt'];
for (var _i = 0, values_1 = values; _i < values_1.length; _i++) {
    var value = values_1[_i];
    console.log(value);
}
//array
console.log(values.pop());
console.log(values.push("diyora"));
console.log(values.splice(4, 1));
console.log(values.sort());
console.log(values.reverse());
console.log(values.shift());
console.log(values.unshift());
console.log(values.shift());
console.log(values.shift());
console.log(values.indexOf('surat'));
//multi
var mArray = [[1, 2, 3], [5, 6, 7]];
console.log(mArray[0][0]);
console.log(mArray[0][1]);
console.log(mArray[0][2]);
console.log();
console.log(mArray[1][0]);
console.log(mArray[1][1]);
console.log(mArray[1][2]);
//for
var arr = new Array("dhruvit", "2200", "diyoraa", "5232");
for (var i = 0; i < arr.length; i++) {
    console.log(arr[i]);
}
//for in
var arr2 = [10, 20, 30, 40];
for (var index in arr2) {
    console.log(index); // prints indexes: 0, 1, 2, 3
    console.log(arr[index]); // prints elements: 10, 20, 30, 40
}
//for of
for (var _a = 0, arr_1 = arr; _a < arr_1.length; _a++) {
    var val = arr_1[_a];
    console.log(val); // prints values: 10, 20, 30, 40
}
//while
var d = 2;
while (d < 4) {
    console.log("line no." + d);
    d++;
}
//do while
var y = 4;
do {
    console.log("line no." + y);
    y++;
} while (y < 4);
//if
var e = 10, f = 20;
if (e > f) {
    console.log('e is greater than f.');
}
else {
    console.log('e is less than or equal to f.'); //This will be executed
}
//else if
var x = 10, z = 20;
if (x > z) {
    console.log('x is greater than z.');
}
else if (x < z) {
    console.log('x is less than z.'); //This will be executed
}
else if (x == z) {
    console.log('x is equal to z');
}
