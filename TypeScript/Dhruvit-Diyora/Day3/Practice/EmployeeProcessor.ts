//importing code in object
import { Employee } from "./Employee";
let empObj = new Employee("dhruvit", 1);
empObj.displayEmployee();

//Importing the Entire Module into a Variable
import * as Emp from "./Employee"
console.log(Emp.age); 

let empObj2 = new Emp.Employee("diyora" , 2);
empObj2.displayEmployee();


// Renaming an Export from a Module:
import { Employee as Associate } from "./Employee"
let obj = new Associate("rohit sharma" , 3);
obj.displayEmployee();

//tsc --module amd Employee.ts

//tsc --module amd EmployeeProcessor.ts
