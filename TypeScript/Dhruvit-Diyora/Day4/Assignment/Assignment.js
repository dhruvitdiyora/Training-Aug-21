var emp = [{ Id: 1, Name: "dhruvit", City: "surat", DOJ: new Date("2002-01-05") }, { Id: 2, Name: "shubh", City: "ahmedabad", DOJ: new Date("2012-01-05") }, { Id: 3, Name: "hemanshu", City: "vadodara", DOJ: new Date("2022-01-05") }, { Id: 4, Name: "piyush", City: "rajkot", DOJ: new Date("2011-01-05") }, { Id: 1, Name: "niraj", City: "surat", DOJ: new Date("20115-01-05") }];
function searchEmp(id) {
    emp.forEach(function (element) {
        if (element.Id = id) {
            console.log("ID ".concat(element.Id, " \n Name ").concat(element.Name, " \n City ").concat(element.City, " \n DOJ ").concat(element.DOJ));
        }
    });
}
searchEmp(5);
// Search the employees who has joined after year 2020
emp.forEach(function (e) {
    if (e.DOJ.getFullYear() > 2020) {
        console.log("ID ".concat(e.Id, " \n Name ").concat(e.Name, " \n City ").concat(e.City, " \n DOJ ").concat(e.DOJ));
    }
});
// Search the employee who has joined after year 2020 and stays in Mumbai city
emp.forEach(function (e) {
    if (e.DOJ.getFullYear() > 2020 && e.City == "mumbai") {
        console.log("ID ".concat(e.Id, " \n Name ").concat(e.Name, " \n City ").concat(e.City, " \n DOJ ").concat(e.DOJ));
    }
});
