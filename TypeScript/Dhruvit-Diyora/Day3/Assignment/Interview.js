"use strict";
exports.__esModule = true;
exports.Interview = void 0;
var ApplicantData_1 = require("./ApplicantData");
var Interview = /** @class */ (function () {
    function Interview() {
    }
    Interview.prototype.StartInterview = function (startedName) {
        startedName.forEach(function (element) {
            ApplicantData_1.applicantData.forEach(function (appl) {
                if (appl.fname == element) {
                    appl.interViewDate = new Date();
                    appl.interViewStart = true;
                }
            });
        });
    };
    Interview.prototype.EndInterview = function (endName) {
        endName.forEach(function (element) {
            ApplicantData_1.applicantData.forEach(function (appl) {
                if (appl.fname == element) {
                    appl.interViewEnd = true;
                }
            });
        });
    };
    Interview.prototype.HireApplicant = function (hireedName) {
        hireedName.forEach(function (element) {
            ApplicantData_1.applicantData.forEach(function (appl) {
                if (appl.fname == element) {
                    appl.hired = true;
                    appl.joiningDate = new Date();
                }
            });
        });
    };
    Interview.prototype.ClearApplicant = function (clearedName) {
        clearedName.forEach(function (element) {
            ApplicantData_1.applicantData.forEach(function (appl) {
                if (appl.fname == element) {
                    appl.cleared = true;
                }
            });
        });
    };
    return Interview;
}());
exports.Interview = Interview;
