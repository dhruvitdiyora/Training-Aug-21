// Store 5 employees’ data in one array (ID,FirstName,LastName,Address,Salary). Do the operation searching by indexnumber, EmployeeID, Insert the employee, delete the employee from the Array. Create one more array emp and join the value with above array. When display list combine firstname and lastname as fullname, From the address field flatnumber,city,state and should be splited.PF should be computed and total salary should be display.

type employee = {
    EmpId:Number,
    FirstName:String,
    LastName:String,
    Address:String,
    Salary:Number
}

var emp:employee[] = [];

//adding 5 employees
emp.push({EmpId:1,FirstName:"Dhruvit",LastName:"Diyora",Address:"208,katargam,surat,gujarat", Salary:1000})

emp.push({EmpId:2,FirstName:"Dh",LastName:"Diy",Address:"209,katar,surat,gujarat", Salary:1200})

emp.push({EmpId:3,FirstName:"Dhr",LastName:"Diy",Address:"210,katargam,surat,gujarat", Salary:1200})

emp.push({EmpId:4,FirstName:"Dhru",LastName:"Diyo",Address:"211,katargam,surat,gujarat",Salary:1300})

emp.push({EmpId:5,FirstName:"Dhruv", LastName:"Diyor",Address:"212,katargam,surat,gujarat", Salary:1400})


//searching employye by index
function searchByIndex (array,index) : employee {
    if(index >= array.length){
        return null;
    }
    return emp[index];
}

var emp5: employee = searchByIndex(emp,4);
console.log(emp5);


//searching employye by empId
function searchByEmployeeId(array,key) : employee {
    return array.filter(emp => emp.EmpId === key)[0];
}

var emp4 = searchByEmployeeId(emp,4);
console.log(emp4);

//adding employee

emp.push({EmpId:6,FirstName:"ddhruvit",LastName:"ddiyora",Address:"Surat",Salary:1500});

console.log(emp);

//removing employee
emp.pop();
emp.splice(3,1)

console.log(emp);


//Create one more array emp and join the value with above array
var emp2:employee[] = [{EmpId:7,FirstName:"Dhruvit",LastName:"Diyora",Address:"213,katargam,surat,gujarat", Salary:1500}];
//concat
var emp3 = emp.concat(emp2);


//display
for(var emps of emp3){
    console.log(`Name: ${emps.FirstName} ${emps.LastName} `);
    var address = emps.Address.split(",");
    console.log(`flatnumber:${address[0]}, flat: ${address[1]} , City: ${address[2]}, state: ${address[3]}`);
    var pf = emps.Salary.valueOf() * 0.12;
    console.log(`PF : ${pf} TotaSalary: ${emps.Salary.valueOf() - pf}`);
}