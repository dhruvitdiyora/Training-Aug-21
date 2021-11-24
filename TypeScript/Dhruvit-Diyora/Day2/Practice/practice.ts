//classes
class Points{
    x = 0;
    y = 0;
}

const pt = new Points();
console.log(`${pt.x},${pt.y}`);
//error
//pt.x = "d";


//constructor
class Greetigs{
    name: String;
    constructor() {
        this.name="dhruvit"
    }
}


//readonly property
class Greeter{
    readonly name: string = "Dhruvit"
    constructor(lastname?: string) {
        if (lastname !== undefined) {
            this.name = lastname;
        }
    }
}
const g = new Greeter();
//can't change
//g.name="dhruvitttt"


//super class
class Base{
    k = 4;
}
class Derives extends Base{
    constructor() {
        //we have to call super otherwse it shows an error
        super();
        console.log(this.k)
        
    }
}

//inheritance
class Animal {
  name: string;
  constructor(theName: string) {
    this.name = theName;
  }
  move(distanceInMeters: number = 0) {
    console.log(`${this.name} moved ${distanceInMeters}m.`);
  }
}
 
class Snake extends Animal {
  constructor(name: string) {
    super(name);
  }
  move(distanceInMeters = 5) {
    console.log("Slithering...");
    super.move(distanceInMeters);
  }
}
 
class Horse extends Animal {
  constructor(name: string) {
    super(name);
  }
  move(distanceInMeters = 45) {
    console.log("Galloping...");
    super.move(distanceInMeters);
  }
}
 
let sam = new Snake("Sammy the Python");
let tom: Animal = new Horse("Tommy the Palomino");
 
sam.move();
tom.move(34);


// using modifiers
class Animals {
  private name: string;
  constructor(theName: string) {
    this.name = theName;
  }
}
 
class Rhino extends Animals {
  constructor() {
    super("Rhino");
  }
}
 
class Employees {
  private name: string;
  constructor(theName: string) {
    this.name = theName;
  }
}
 
let animal = new Animals("Goat");
let rhino = new Rhino();
let employee = new Employees("dhruvit");
 
animal = rhino;
//private so won't work
// animal.name;

//can't change type 
// animal = employee;

//protected
class Person {
  protected name: string;
  constructor(name: string) {
    this.name = name;
  }
}
 
class Employeess extends Person {
  private department: string;
 
  constructor(name: string, department: string) {
    super(name);
    this.department = department;
  }
 
  public getElevatorPitch() {
    return `Hello, my name is ${this.name} and I work in ${this.department}.`;
  }
}
 
let dhruvit = new Employeess("dhruvit", "SM");
console.log(dhruvit.getElevatorPitch());
//can't access name outside class and it's subclasses
// console.log(dhruvit.name);

//static properties
class Grid {
  static origin = { x: 0, y: 0 };
 
  calculateDistanceFromOrigin(point: { x: number; y: number }) {
    let xDist = point.x - Grid.origin.x;
    let yDist = point.y - Grid.origin.y;
    return Math.sqrt(xDist * xDist + yDist * yDist) / this.scale;
  }
 
  constructor(public scale: number) {}
}
 
let grid1 = new Grid(1.0); // 1x scale
let grid2 = new Grid(5.0); // 5x scale
 
console.log(grid1.calculateDistanceFromOrigin({ x: 10, y: 10 }));
console.log(grid2.calculateDistanceFromOrigin({ x: 10, y: 10 }));


//abstract class
abstract class Department {
  constructor(public name: string) {}
 
  printName(): void {
    console.log("Department name: " + this.name);
  }
 
  abstract printMeeting(): void; // must be implemented in derived classes
}
 
class AccountingDepartment extends Department {
  constructor() {
    super("Accounting and Auditing"); // constructors in derived classes must call super()
  }
 
  printMeeting(): void {
    console.log("The Accounting Department meets each Monday at 10am.");
  }
 
  generateReports(): void {
    console.log("Generating accounting reports...");
  }
}
 
let department: Department; // ok to create a reference to an abstract type
//department = new Department(); // error: cannot create an instance of an abstract class Cannot create an instance of an abstract class.
department = new AccountingDepartment(); // ok to create and assign a non-abstract subclass
department.printName();
department.printMeeting();
//department.generateReports(); // error: department is not of type AccountingDepartment, cannot access generateReports


//Function
class Rectangle{
    x = 10;
    y = 20;
    scale(n:number):void {
        this.x *= n;
        this.y *= n;
    }

}
let rect = new Rectangle();
console.log(rect.scale(12));
class Employee{
    empCode: number;
    empName: string;
    constructor(code: number, name: string) {
        this.empName = name;
        this.empCode = code;
    }
    getSalary(): number{
        return 10000;
    }
}

let emp9 = new Employee(12, "dhruvit diyora");
console.log(emp9.getSalary());

//tuple
let a: [string, number];
a = ["hi", 12]

var employees: [number, string][];
employees = [[1, "dhruvit"], [2, "dhruv"], [3, "diyora"]];
console.log(employees);

function display(value: (number | string)) {
    if (typeof (value) === "number")
        console.log("this is number");
    else if (typeof (value) === "string")
        console.log("this is string");
}
display(123);
display("ABC");

//enums
enum Color{
    Red,
    Green,
    Blue
}

var c: Color;
c = Color.Green;
console.log(c);

//interface
interface IEmployee1{
    empCode: number;
    name: string;
    getSalary: (number) => number;
}
class Employee1 implements IEmployee1 {
    empCode: number;
    name: string;
    constructor(code: number, name: string) {
        this.empCode = code;
        this.name = name;
        
    }
    getSalary(empCode:number): number{
        return empCode;
    }
}
let emp8 = new Employee1(1, "dhruv");
console.log(emp8.getSalary(20000));

//interface as type
interface KeyPair{
    key: number;
    value: string;
}

let kv1: KeyPair = { key: 1, value: "dhruvit" };

//interface as function Type
interface KeyValueProcessor{
    (key: number, value: string): void;
};

function addKeyValue(key:number,value:string): void{
    console.log('addKeyValue:key= '+key+',value'+value  );
}

let kvp: KeyValueProcessor = addKeyValue;
kvp(1, 'Bill');

//interface for array type
interface NumList{
    [index: number]: number;
}
let numArr: NumList = [1, 2, 3];
numArr[0];
numArr[1];

//Indexable Types
interface StringArray {
  [index: number]: string;
}
 
let myArray: StringArray;
myArray = ["Bob", "Fred"];
 
let myStr: string = myArray[0];


// interface for creating properties
interface IEmployee3{
    empCode: number;
    empName: string;
    empDept?: string;
    readonly SSN: number;
}

let empObj1: IEmployee3 = {
    empCode: 1,
    empName: "dhruv",
    SSN: 20
}

//extending interfaces
interface Iperson{
    name: string;
    gender: string;
}

interface IEmployee4 extends Iperson{
    empCode: number;
}

let empObj2: IEmployee4 = {
    empCode: 1,
    name: "dhruv",
    gender:"male"
}

function add(x: number, y: number): number {
  return x + y;
}
 
//Typing the function

let myAdd = function (x: number, y: number): number {
  return x + y;
};

//union
interface Bird {
  fly(): void;
  layEggs(): void;
}
 
interface Fish {
  swim(): void;
  layEggs(): void;
}
 
declare function getSmallPet(): Fish | Bird;
 
let pet = getSmallPet();
pet.layEggs();
 
// Only available in one of the two possible types
//pet.swim();

//intersection
interface ErrorHandling {
  success: boolean;
  error?: { message: string };
}
 
interface ArtworksData {
  artworks: { title: string }[];
}
 
interface ArtistsData {
  artists: { name: string }[];
}
 
// These interfaces are composed to have
// consistent error handling, and their own data.
 
type ArtworksResponse = ArtworksData & ErrorHandling;
type ArtistsResponse = ArtistsData & ErrorHandling;
 
const handleArtistsResponse = (response: ArtistsResponse) => {
  if (response.error) {
    console.error(response.error.message);
    return;
  }
 
  console.log(response.artists);
};
