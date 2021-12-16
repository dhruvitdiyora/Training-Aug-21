//Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.
type empData = {
    Id: number;
    Name: string;
    City: string;
    DOJ: Date;
}

var emp: empData[] = [{ Id: 1, Name: "dhruvit", City: "surat", DOJ: new Date("2002-01-05") }, { Id: 2, Name: "shubh", City: "ahmedabad", DOJ: new Date("2012-01-05") }, { Id: 3, Name: "hemanshu", City: "vadodara", DOJ: new Date("2022-01-05") }, { Id: 4, Name: "piyush", City: "rajkot", DOJ: new Date("2011-01-05") }, { Id: 1, Name: "niraj", City: "surat", DOJ: new Date("2015-01-05") }];

function searchEmp(id: number): void {
    emp.forEach(element => {
        if (element.Id == id) {
            console.log(`ID ${element.Id} \n Name ${element.Name} \n City ${element.City} \n DOJ ${element.DOJ}`);
        }
        
    });
}
searchEmp(5);

// Search the employees who has joined after year 2020
emp.forEach(e => {
    if (e.DOJ.getFullYear() > 2020) {
            console.log(`ID ${e.Id} \n Name ${e.Name} \n City ${e.City} \n DOJ ${e.DOJ}`);
        }
});
// Search the employee who has joined after year 2020 and stays in Mumbai city
emp.forEach(e => {
    if (e.DOJ.getFullYear() > 2020 && e.City=="mumbai") {
            console.log(`ID ${e.Id} \n Name ${e.Name} \n City ${e.City} \n DOJ ${e.DOJ}`);
        }
});
