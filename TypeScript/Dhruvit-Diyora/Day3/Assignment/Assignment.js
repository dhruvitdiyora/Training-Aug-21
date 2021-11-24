"use strict";
//This project is aimed at developing a web-based and central Recruitment Process System for the HR Group for a company. Some features of this system will be creating vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews, Storing Interview results for the applicant and finally Hiring of the applicant. Reports may be required to be generated for the use of HR group.
exports.__esModule = true;
var Vacancies_1 = require("./Vacancies");
//creating object of vacancies
var v = new Vacancies_1.vacancies();
v.AddVacancy("web developer", "5 year", 100, 200, "surat", "1 month", "dotnet");
v.ShowVacancy();
var Applicants_1 = require("./Applicants");
var a = new Applicants_1.Applicants();
a.addApplicants("dhruvit", "diyora", "web developer");
a.ShowApplicants();
var Interview_1 = require("./Interview");
var i = new Interview_1.Interview();
i.StartInterview(["dhruvit", "diyora"]);
i.EndInterview(["dhruvit", "diyora"]);
i.ClearApplicant(["dhruvit", "diyora"]);
i.HireApplicant(["dhruvit", "diyora"]);
var ApplicantData_1 = require("./ApplicantData");
console.log("Details from all applicants");
console.log(ApplicantData_1.applicantData);
