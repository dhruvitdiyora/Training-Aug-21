//map

//create
var map = new Map();  

//map methods
map.set('1', 'dhruvit');     
map.set(1, 'diyora');       
map.set(true, 'boolean');   
map.set('2', 'ddd');  
  
console.log( "1= " +map.get(1)   );   
console.log("2= " + map.get('1') );   
console.log( "Key is Present= " +map.has(3) );   
console.log( "Size= " +map.size );   
console.log( "Delete value= " +map.delete(1) );   
console.log( "New Size= " +map.size );  
console.log(map);
map.clear();

console.log(map);


//example
let ageMapes = new Map();

ageMapes.set("dhruvit", 20);
ageMapes.set("diyora", 21);
ageMapes.set("ddhruvit", 22);

//Iterate over map keys  
for (let key of ageMapes.keys()) {
  console.log("Map Keys= " + key);
}
//Iterate over map values  
for (let value of ageMapes.values()) {
  console.log("Map Values= " + value);
}

console.log("The Map Enteries are: ");

//Iterate over map entries
for (let entry of ageMapes.entries()) {
  console.log(entry[0], entry[1]);
}

//Set

//create
let studentEntries = new Set();

//Add Values
studentEntries.add("dhruvit");
studentEntries.add("diyora");
studentEntries.add("rohit");
studentEntries.add("Kohli");
studentEntries.add("ddiyora");
  
//Returns Set data  
console.log(studentEntries);   
   
//Check value is present or not  
console.log(studentEntries.has("Kohli"));
console.log(studentEntries.has(10));

//It returns size of Set  
console.log(studentEntries.size);

//Delete a value from set  
console.log(studentEntries.delete("rohit"));

//Clear whole Set
studentEntries.clear();

//Returns Set data after clear method.  
console.log(studentEntries);

//adding using chain 
studentEntries.add("dh").add("dhr").add("dhru").add("dhruvit");

//Returns Set data
console.log("The List of Set values:");
console.log(studentEntries);

//for...of
//iterate
for (let student of studentEntries) {
  console.log(student);
}

//foreach
studentEntries.forEach(function (value) {
  console.log(value);
});


//date objects
let date: Date = new Date();  

console.log(date);

//milliseconds
let date1: Date = new Date(500000000000);  
console.log(date1);

//datestring
let date2: Date = new Date("2021-11-24");
let date3: Date = new Date("2021-24-11");

//will not work
let date4: Date = new Date("11-24-2021");
let date5: Date = new Date("24-11-2021");
console.log(date2);
console.log(date3);
console.log(date4);

let date6: Date = new Date(2021, 11, 21, 15, 16, 42, 11);  
console.log(date6);
//methods
date6.setDate(13);  
date6.setMonth(13);  
date6.setFullYear(2013);  
date6.setHours(13);  
date6.setMinutes(13);  
date6.setSeconds(13);  
console.log("Year = " + date6.getFullYear());  
console.log("Date = " + date6.getDate());  
console.log("Month = " + date6.getMonth());  
console.log("Day = " + date6.getDay());  
console.log("Hours = " + date6.getHours());  
console.log("Minutes = " + date6.getMinutes());  
console.log("Seconds = " + date6.getSeconds());  
