var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//classes
var Points = /** @class */ (function () {
    function Points() {
        this.x = 0;
        this.y = 0;
    }
    return Points;
}());
var pt = new Points();
console.log("".concat(pt.x, ",").concat(pt.y));
//error
//pt.x = "d";
//constructor
var Greetigs = /** @class */ (function () {
    function Greetigs() {
        this.name = "dhruvit";
    }
    return Greetigs;
}());
//readonly property
var Greeter = /** @class */ (function () {
    function Greeter(lastname) {
        this.name = "Dhruvit";
        if (lastname !== undefined) {
            this.name = lastname;
        }
    }
    return Greeter;
}());
var g = new Greeter();
//can't change
//g.name="dhruvitttt"
//super class
var Base = /** @class */ (function () {
    function Base() {
        this.k = 4;
    }
    return Base;
}());
var Derives = /** @class */ (function (_super) {
    __extends(Derives, _super);
    function Derives() {
        var _this = 
        //we have to call super otherwse it shows an error
        _super.call(this) || this;
        console.log(_this.k);
        return _this;
    }
    return Derives;
}(Base));
//inheritance
var Animal = /** @class */ (function () {
    function Animal(theName) {
        this.name = theName;
    }
    Animal.prototype.move = function (distanceInMeters) {
        if (distanceInMeters === void 0) { distanceInMeters = 0; }
        console.log("".concat(this.name, " moved ").concat(distanceInMeters, "m."));
    };
    return Animal;
}());
var Snake = /** @class */ (function (_super) {
    __extends(Snake, _super);
    function Snake(name) {
        return _super.call(this, name) || this;
    }
    Snake.prototype.move = function (distanceInMeters) {
        if (distanceInMeters === void 0) { distanceInMeters = 5; }
        console.log("Slithering...");
        _super.prototype.move.call(this, distanceInMeters);
    };
    return Snake;
}(Animal));
var Horse = /** @class */ (function (_super) {
    __extends(Horse, _super);
    function Horse(name) {
        return _super.call(this, name) || this;
    }
    Horse.prototype.move = function (distanceInMeters) {
        if (distanceInMeters === void 0) { distanceInMeters = 45; }
        console.log("Galloping...");
        _super.prototype.move.call(this, distanceInMeters);
    };
    return Horse;
}(Animal));
var sam = new Snake("Sammy the Python");
var tom = new Horse("Tommy the Palomino");
sam.move();
tom.move(34);
// using modifiers
var Animals = /** @class */ (function () {
    function Animals(theName) {
        this.name = theName;
    }
    return Animals;
}());
var Rhino = /** @class */ (function (_super) {
    __extends(Rhino, _super);
    function Rhino() {
        return _super.call(this, "Rhino") || this;
    }
    return Rhino;
}(Animals));
var Employees = /** @class */ (function () {
    function Employees(theName) {
        this.name = theName;
    }
    return Employees;
}());
var animal = new Animals("Goat");
var rhino = new Rhino();
var employee = new Employees("dhruvit");
animal = rhino;
//private so won't work
// animal.name;
//can't change type 
// animal = employee;
//protected
var Person = /** @class */ (function () {
    function Person(name) {
        this.name = name;
    }
    return Person;
}());
var Employeess = /** @class */ (function (_super) {
    __extends(Employeess, _super);
    function Employeess(name, department) {
        var _this = _super.call(this, name) || this;
        _this.department = department;
        return _this;
    }
    Employeess.prototype.getElevatorPitch = function () {
        return "Hello, my name is ".concat(this.name, " and I work in ").concat(this.department, ".");
    };
    return Employeess;
}(Person));
var dhruvit = new Employeess("dhruvit", "SM");
console.log(dhruvit.getElevatorPitch());
//can't access name outside class and it's subclasses
// console.log(dhruvit.name);
//static properties
var Grid = /** @class */ (function () {
    function Grid(scale) {
        this.scale = scale;
    }
    Grid.prototype.calculateDistanceFromOrigin = function (point) {
        var xDist = point.x - Grid.origin.x;
        var yDist = point.y - Grid.origin.y;
        return Math.sqrt(xDist * xDist + yDist * yDist) / this.scale;
    };
    Grid.origin = { x: 0, y: 0 };
    return Grid;
}());
var grid1 = new Grid(1.0); // 1x scale
var grid2 = new Grid(5.0); // 5x scale
console.log(grid1.calculateDistanceFromOrigin({ x: 10, y: 10 }));
console.log(grid2.calculateDistanceFromOrigin({ x: 10, y: 10 }));
//abstract class
var Department = /** @class */ (function () {
    function Department(name) {
        this.name = name;
    }
    Department.prototype.printName = function () {
        console.log("Department name: " + this.name);
    };
    return Department;
}());
var AccountingDepartment = /** @class */ (function (_super) {
    __extends(AccountingDepartment, _super);
    function AccountingDepartment() {
        return _super.call(this, "Accounting and Auditing") || this;
    }
    AccountingDepartment.prototype.printMeeting = function () {
        console.log("The Accounting Department meets each Monday at 10am.");
    };
    AccountingDepartment.prototype.generateReports = function () {
        console.log("Generating accounting reports...");
    };
    return AccountingDepartment;
}(Department));
var department; // ok to create a reference to an abstract type
//department = new Department(); // error: cannot create an instance of an abstract class Cannot create an instance of an abstract class.
department = new AccountingDepartment(); // ok to create and assign a non-abstract subclass
department.printName();
department.printMeeting();
//department.generateReports(); // error: department is not of type AccountingDepartment, cannot access generateReports
//Function
var Rectangle = /** @class */ (function () {
    function Rectangle() {
        this.x = 10;
        this.y = 20;
    }
    Rectangle.prototype.scale = function (n) {
        this.x *= n;
        this.y *= n;
    };
    return Rectangle;
}());
var rect = new Rectangle();
console.log(rect.scale(12));
var Employee = /** @class */ (function () {
    function Employee(code, name) {
        this.empName = name;
        this.empCode = code;
    }
    Employee.prototype.getSalary = function () {
        return 10000;
    };
    return Employee;
}());
var emp9 = new Employee(12, "dhruvit diyora");
console.log(emp9.getSalary());
//tuple
var a;
a = ["hi", 12];
var employees;
employees = [[1, "dhruvit"], [2, "dhruv"], [3, "diyora"]];
console.log(employees);
function display(value) {
    if (typeof (value) === "number")
        console.log("this is number");
    else if (typeof (value) === "string")
        console.log("this is string");
}
display(123);
display("ABC");
//enums
var Color;
(function (Color) {
    Color[Color["Red"] = 0] = "Red";
    Color[Color["Green"] = 1] = "Green";
    Color[Color["Blue"] = 2] = "Blue";
})(Color || (Color = {}));
var c;
c = Color.Green;
console.log(c);
var Employee1 = /** @class */ (function () {
    function Employee1(code, name) {
        this.empCode = code;
        this.name = name;
    }
    Employee1.prototype.getSalary = function (empCode) {
        return empCode;
    };
    return Employee1;
}());
var emp8 = new Employee1(1, "dhruv");
console.log(emp8.getSalary(20000));
var kv1 = { key: 1, value: "dhruvit" };
;
function addKeyValue(key, value) {
    console.log('addKeyValue:key= ' + key + ',value' + value);
}
var kvp = addKeyValue;
kvp(1, 'Bill');
var numArr = [1, 2, 3];
numArr[0];
numArr[1];
var myArray;
myArray = ["Bob", "Fred"];
var myStr = myArray[0];
var empObj1 = {
    empCode: 1,
    empName: "dhruv",
    SSN: 20
};
var empObj2 = {
    empCode: 1,
    name: "dhruv",
    gender: "male"
};
function add(x, y) {
    return x + y;
}
//Typing the function
var myAdd = function (x, y) {
    return x + y;
};
var pet = getSmallPet();
pet.layEggs();
var handleArtistsResponse = function (response) {
    if (response.error) {
        console.error(response.error.message);
        return;
    }
    console.log(response.artists);
};
