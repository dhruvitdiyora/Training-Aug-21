define(["require", "exports", "./Employee", "./Employee", "./Employee"], function (require, exports, Employee_1, Emp, Employee_2) {
    "use strict";
    exports.__esModule = true;
    var empObj = new Employee_1.Employee("dhruvit", 1);
    empObj.displayEmployee();
    console.log(Emp.age);
    var empObj2 = new Emp.Employee("diyora", 2);
    empObj2.displayEmployee();
    var obj = new Employee_2.Employee("rohit sharma", 3);
    obj.displayEmployee();
});
//tsc --module amd Employee.ts
//tsc --module amd EmployeeProcessor.ts
