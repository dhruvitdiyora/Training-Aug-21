"use strict";
exports.__esModule = true;
exports.Applicants = void 0;
var ApplicantData_1 = require("./ApplicantData");
var Applicants = /** @class */ (function () {
    function Applicants() {
    }
    Applicants.prototype.addApplicants = function (fname, lname, role) {
        try {
            ApplicantData_1.applicantData.push({ fname: fname, lname: lname, role: role, applicationDate: new Date() });
            console.log("Application Submitted");
        }
        catch (e) {
            console.error(e);
        }
    };
    Applicants.prototype.ShowApplicants = function () {
        console.log("applicant list");
        console.log(ApplicantData_1.applicantData);
    };
    return Applicants;
}());
exports.Applicants = Applicants;
