/// <reference path="./StringUtility.ts" />

class Employee {
    empCode: number;
    empName: string;
    constructor(name: string, code: number) {
        this.empCode = code;
        this.empName = StringUtility.ToCapital(name);
    }
    displayEmployee() {
        console.log ("Employee Code: " + this.empCode + ", Employee Name: " + this.empName );
    }
}
var emp = new Employee("dhruvit", 2);
emp.displayEmployee();
//sc --target es6 Employees.ts --outfile Employeeee.js