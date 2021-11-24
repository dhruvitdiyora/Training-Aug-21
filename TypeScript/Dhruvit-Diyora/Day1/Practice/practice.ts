var num1:number = 7;
console.log(num1);

var str1:string = "Hello world"
console.log(str1);

var isTrue:boolean = true;

console.log(isTrue);

//functions

function hello(person:string): void {
    console.log(`hello ${person}`);
}
hello("d");

//Array

var nums:number[] = [1,2,3,4,5,6];
var nusm2:Array<number> = [9,8,7,6,5,4,3]

var names:string[] = ["a","b","c","d","e"];


//any type

let obj: any = { x: 0 };
obj.foo();
obj();
obj.bar = 100;
obj = "hello";
const n: number = obj;

//Type Annotations on Variables

let myName:string = "Dhruvit";
let myName2 = "diyora"

//anonymous fun

names.forEach((s) => {
    console.log(s.toUpperCase());
})


//object type

function ShowName(fname:string,lname:string) {
    console.log("first name " + fname +"last name " + lname );
}
ShowName("dhruvit","diyora")


function printCoord(pt: { x: number; y: number }) {
  console.log("The coordinate's x value is " + pt.x);
  console.log("The coordinate's y value is " + pt.y);
}
printCoord({ x: 3, y: 7 });


//Optional Properties
function printName(obj: { first: string; last?: string }) {
  console.log("first name " + obj.first +"last name " + obj.last );
}
// Both OK
printName({ first: "dhruvit" });
printName({ first: "dhruvit", last: "diyora" });


//Union Types

function printId(id: number | string) {
  console.log("Your ID is: " + id);
}
// OK
printId(101);
// OK
printId("202");
// Error
//printId({ myID: 22342 });
function printIds(id: number | string) {
  if (typeof id === "string") {
    // In this branch, id is of type 'string'
    console.log(id.toUpperCase());
  } else {
    // Here, id is of type 'number'
    console.log(id);
  }
}
printIds(101);
// OK
printIds("dhruvit");
//number

let number1:number = 3.14285742857;
console.log(number1.toExponential(6));
console.log(number1.toFixed(6));
console.log(number1.valueOf());
console.log(number1.toString());
console.log(number1.toLocaleString());




//string

let str:string = "valar morghulis!";
console.log(str.charAt(5));
console.log(str.concat("dddd"));
console.log(str.indexOf("m"));
console.log(str.replace("morghulis","dohaireas"));
console.log(str.split(" "));
console.log(str.toUpperCase());
console.log(str.toLowerCase());
console.log(str.slice(3,5));
console.log(str.substr(3, 3));


//multi Type Array

let values: (string | number)[] = ['dhruvit',1,'diyora',3,2,6,'surat','dhruvitt'];

for(var value of values){
    console.log(value)
}

//array

console.log(values.pop());
console.log(values.push("diyora"));
console.log(values.splice(4,1));
console.log(values.sort());
console.log(values.reverse());
console.log(values.shift());
console.log(values.unshift());
console.log(values.shift());
console.log(values.shift());
console.log(values.indexOf('surat'));

//multi
var mArray:number[][] = [[1,2,3],[5,6,7]] ;  
console.log(mArray[0][0]);  
console.log(mArray[0][1]);  
console.log(mArray[0][2]);  
console.log();  
console.log(mArray[1][0]);  
console.log(mArray[1][1]);  
console.log(mArray[1][2]);  


//for
let arr:string[] = new Array("dhruvit","2200","diyoraa","5232");  
for(var i = 0;i<arr.length;i++) {   
   console.log(arr[i]);  
}

//for in
let arr2 = [10, 20, 30, 40];

for (var index in arr2) {
  console.log(index); // prints indexes: 0, 1, 2, 3

  console.log(arr[index]); // prints elements: 10, 20, 30, 40
}
//for of
for (var val of arr) {
  console.log(val); // prints values: 10, 20, 30, 40
}


//while
let d: number = 2;

while (d < 4) {
    console.log( "line no." + d )
    d++;
}

//do while
let y: number = 4;
do {
    console.log( "line no." + y )
    y++;
} while ( y < 4)



//if
let e: number = 10, f = 20;

if (e > f) 
{
    console.log('e is greater than f.');
} 
else
{
    console.log('e is less than or equal to f.'); //This will be executed
}


//else if
let x: number = 10, z = 20;

if (x > z) 
{
    console.log('x is greater than z.');
} 
else if (x < z)
{
    console.log('x is less than z.'); //This will be executed
}
else if (x == z) 
{
    console.log('x is equal to z');
}


