//This project is aimed at developing a web-based and central Recruitment Process System for the HR Group for a company. Some features of this system will be creating vacancies, storing Applicants data, Interview process initiation, Scheduling Interviews, Storing Interview results for the applicant and finally Hiring of the applicant. Reports may be required to be generated for the use of HR group.

import {vacancies} from './Vacancies';
//creating object of vacancies
var v = new vacancies();
v.AddVacancy("web developer","5 year",100,200,"surat","1 month","dotnet");
v.ShowVacancy();

import { Applicants } from './Applicants';
var a = new Applicants();
a.addApplicants("dhruvit","diyora","web developer");
a.ShowApplicants();

import { Interview } from './Interview';
var i = new Interview();
i.StartInterview(["dhruvit","diyora"]);
i.EndInterview(["dhruvit","diyora"]);
i.ClearApplicant(["dhruvit","diyora"]);
i.HireApplicant(["dhruvit", "diyora"]);


import { applicantData } from './ApplicantData';
console.log("Details from all applicants");
console.log(applicantData);

