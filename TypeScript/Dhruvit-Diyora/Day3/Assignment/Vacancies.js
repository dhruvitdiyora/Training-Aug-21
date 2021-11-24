"use strict";
exports.__esModule = true;
exports.vacancies = void 0;
var vacancyData = [];
var vacancies = /** @class */ (function () {
    function vacancies() {
    }
    vacancies.prototype.AddVacancy = function (rol, exp, minS, maxS, loc, join, tech) {
        try {
            vacancyData.push({ role: rol, experience: exp, minSalary: minS, maxSalary: maxS, location: loc, joining: join, technology: tech });
            console.log("VacancyData Added");
        }
        catch (e) {
            console.error(e);
        }
    };
    vacancies.prototype.ShowVacancy = function () {
        vacancyData.forEach(function (vacant) {
            console.log("Hello job seeker\n we are having an opening for ".concat(vacant.role, " \n in ").concat(vacant.technology, " technology with minimum experience of ").concat(vacant.experience, " , expected salary is between ").concat(vacant.minSalary, "  to ").concat(vacant.maxSalary, " ,\n location is ").concat(vacant.location, " \n "));
        });
    };
    return vacancies;
}());
exports.vacancies = vacancies;
